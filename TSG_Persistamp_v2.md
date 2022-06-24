Stack
- Backend - Python, Flask, SQLAlchemy, Postgres
- Frontend - TypeScript, NextJS, Storybook, redux, toolkit, insomnia, React Native

User
Buddy
Message
Shop
Reward
Receipt
Program
Activity/Task
Stamp



shop
 -> programs -> tasks
 -> rewards

user
can create and edit shops + rewards, programs + tasks
can become program members, then earn points from their shops
can be a shop manager or assistant. 
user features
create, delete, public/members/friends/private
user page - view details, shops, programs, tasks, history, friends...?
edit self
send/remove friend requests, private messages
create shops, programs, tasks
view reward redeem history - all, by shop, time paginated

- privacy mode - page, buddies, managed shops, program memberships, task histories, redemptions
- buddies
- messages
- shops created, managed, assisted
- programs created, managed, assisted, member, points
- tasks created, managed, assisted, stamped history.
- rewards created, favorited, contributed, redeemed

Table users {
  id int [pk, increment]
  created_at timestamp
  name
  summary
  description
  color varchar
  icon varchar
  email varchar
  hashword varchar
  privacy_settings
  buddy_ids [ref: buddies.user2_id]
  sent_message_ids [ref: > messages.from_user_id]
  received_message_ids [ref: > messages.to_user_id]
  redemption_ids [ref: > redemptions.id]
  order_settings: {
    shop_ids [...]
    program_task_ids [['task_id'], [...]]
  }
  starred_shop_id [ref: > shops.id]
  starred_reward_ids [ref: > rewards.id][]

  created_program_ids
  created_shop_ids
  created_reward_ids
  created_task_ids
}

Table buddies {
  id int [pk, increment]
  created_at timestamp
  user1_id [ref: > users.id]
  user2_id [ref: > users.id]
}

Table messages {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  from_user_id [ref: > users.id]
  to_user_id [ref: > users.id]
  message varchar
  program_id, task_id, shop_id
}

shop features
create, delete, public/private
edit name, summary, description, color, icon, image?
add/remove programs + rewards
add/remove managers/assistants. manager has all permissions except delete shop (creator only). assistants, 'ideal': modular roles with different permissions. 'simple': create and control their own programs/rewards and assigned programs/rewards.
shop page - view rewards + programs
merge shops - merged-in shop's rewards, programs+members+points, managers/assistants are added to main shop
open/closed times

Table shops {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  created_by [ref: > users.id]
  privacy_mode 'public'|'invite'|'private'
  availability_schedule {
    months_of_year: [5, 7, 11],
    days_of_week: [0, 1],
    dates: ['blahdate'],
    times: ['02:00:00'],
    date_ranges: [['startdate', 'enddate']]
    time_ranges: [['12:00:00', '02:00:00'], [...]],
    excluded: {}
  }[]

  order_reward_ids [...]
  order_program_ids [...]
  reward_ids [ref: > rewards.shop_id]
  program_ids [ref: > programs.shop_id]
  shop_role_ids [ref: > roles.shop_id]
}

Table roles {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  created_by [ref: > users.id]
  user_id [ref: > users.id]
  role_type 'manager'|'assistant'|'viewer'
  permission_settings {}
  shop_id
  reward_id
  task_id
}

Table memberships {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  user_id [ref: > users.id]
  role_type 'manager'|'assistant'|'stamper'|'member'
  permission_settings {}
  points int
  program_id [ref: > programs.id]
}


reward features
create, delete
edit basic details
choose: cost, quantity, max, per-user limit, per-x-time limit, x recurring renewal by/up to y, availability times, expiry date, group reward, can contribute, can gift, 
view - basic details, last redeemed by who, redemption history, change history
for user - favorite, redeem
view all options - sort options, hide expired/unavailable. default: favorite > redeemable > too expensive > expired/out of stock. normal vs slim

Table rewards {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  created_by [ref: users.id]
  cost int
  quantity int
  group_limit int
  user_limit int
  schedule_settings: {
    limit_reset: {schedule, limit_type: 'group'|'user'|'both'}[],
    quantity_renewal: {schedule, renewal_quantity: int}[],
    availability: {schedule}[],
  }
  expiry_date timestamp
  is_group_reward bool
  redemption_ids [ref: > redemptions.id]
}

Table_redemptions {
  id int [pk, increment]
  created_at timestamp
  user_id [ref: > users.id]
  reward_id [ref: > rewards.id]
  reward_content {id, name, summary, description, color, icon, cost}
}

program features
create, delete, public/members/private
edit basic details
merge programs within the same shop - merges members+points+task
add/remove managers/assistants/stampers/members. managers can do all but delete (shop manager or creator only). assistants create and control their own tasks and be assigned tasks. members can view, stamp tasks for themselves to earn points, and get access to the program's shop to spend the points.
add/remove tasks. 
stamp rule: 1. members self-stamp. 2. members can stamp each other. 3. stampers/assistants/managers can stamp members (assistants only for their tasks)
view page - see details, members/managers/etc., tasks, group stats.

Table programs {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  created_by [ref: > users.id]
  privacy_mode
  membership_mode 'personal'|'invite'|'public'
  stamp_system_type 'self'|'members'|'stampers'

  task_ids [ref: > tasks.id]
}


task features
create, delete
edit basic details
choose: value, allow partial credit, partial value, allow multiple stamps, max multiple, total, deadline, availability schedule, must-stamp-at-time, frequency (quantity per unit), completion bonus, streaks bonus, bonus first time only, milestones bonus, group success bonus, group streak bonus, group milestones bonus, group bonus min membership requirement
by-user settings - total, deadline?, availability schedule+must-stamp-at-time, frequency,
view page: see public users' task history. see own task history. 
add personal notes?

Table tasks {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  created_by [ref: > users.id]
  privacy_mode
  point_value int
  point_value_partial int
  allows_partial bool
  allows_multiple bool
  max_multiple int
  availability_settings {
    must_stamp_during bool
    schedules {}
  }
  frequency_settings { // ex. twice every three days, five times every two weeks
    quantity
    time_unit_quantity
    time_unit 'day'|'week'|'month'|'year'
  }
  target int
  group_target
  bonus_values: {
    reach_total int;
    streaks [{length: int, points: int, is_repeatable: bool}],
    milestones: [{name: varchar, points: int, quantity: int, }]
    {
      name,
      points,
      bonus_type 'streak'|'milestone'|'target'
      quantity,
      is_repeatable,
      is_for_group
      group_streak_min_members
    }
  }
  deadline timestamp
}


post messages? public, program members, invited users, private

