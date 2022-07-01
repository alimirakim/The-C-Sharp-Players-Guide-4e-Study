
Table entities {
  id int [pk, increment]
  edited_at datetime [default: `now()`]
  created_at datetime [default: `now()`]
  name varchar(50)
  summary varchar(250)
  description varchar (5000)
  color varchar
  icon varchar
  privacy_setting privacy_setting
  type
}

Enum entity_type {
  user
  shop
  card
  reward
  task
}

Enum privacy_setting {
  public
  members
  buddies
  invite
  private
}

Table users {
  id int [pk, increment]
  edited_at datetime [default: `now()`]
  created_at datetime [default: `now()`]
  name varchar(50)
  summary varchar(250)
  description varchar(5000)
  color varchar(25) // rgba(255, 255, 255, 0.15)
  icon varchar(25)
  privacy_setting privacy_setting
  email varchar(250)
  hashword varchar(250)
  starred_shop_id int [ref: > shops.id]

  settings json [note: '{
    color_mode: 'dark'|'color_blind'|'light',
    order_shop_ids: ["shop_a"],
    order_card_task_ids: [{card_id: "card_a", task_ids: [...]}]
    order_task_ids: {card_id: [task_id, task_id], ...}
  }']
  
  buddy_ids int [ref: > buddies.user2_id]
  starred_reward_ids int [ref: > starred_rewards.reward_id]
  sent_message_ids int [ref: > messages.from_user_id]
  received_message_ids int [ref: > messages.to_user_id]
  redemption_ids int [ref: > redemptions.id]
  created_card_ids int [ref: > cards.id]
  created_shop_ids int [ref: > shops.id]
  created_reward_ids int [ref: > rewards.id]
  created_task_ids int [ref: > tasks.id]
}

Table starred_rewards {
  id int [pk, increment]
  created_at datetime [default: `now()`]
  user_id int [ref: > users.id]
  reward_id int [ref: > rewards.id]
}

Enum buddy_request_status {
  pending
  accepted
  rejected
}

Table buddies {
  id int [pk, increment]
  created_at timestamp
  user1_id int [ref: > users.id]
  user2_id int [ref: > users.id]
  status buddy_request_status
}

Table requests {

}
Enum message_type {
  friend_request
  card_invite
  shop_invite
  message
}
// DynamoDB? messages, roles
Table messages {
  id int [pk, increment]
  edited_at datetime [default: `now()`]
  created_at datetime [default: `now()`]
  from_user_id int [ref: > users.id]
  to_user_id int [ref: > users.id]
  type message_type
  message varchar(250)
  // card_id, task_id, shop_id, stamp_id
}

Table shops {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  created_by int [ref: > users.id]
  name varchar(50)
  summary varchar(250)
  description varchar(5000)
  color varchar(25)
  icon varchar(25)
  privacy_setting privacy_setting
  stamp_system_type stamp_system_type
  membership_mode membership_mode
  settings json [note: '{
    availability_schedule: {
      months_of_year: [5, 7, 11], // 1-12
      days_of_week: [0, 1], // 1-7
      days_of_month: [1, 31], // 1-31
      presets: [], // year_start, month_end, year_end, holidays
      dates: [blahdate],
      times: [02:00:00],
      date_ranges: [[startdate, enddate]]
      time_ranges: [[12:00:00, 02:00:00], [...]],
      excluded: {}
    },
    order_reward_ids: ['reward_a', 'reward_b'],
    order_card_ids: ['card_a', 'card_b'],
  }']

  reward_ids int [ref: > rewards.shop_id]
  card_ids int [ref: > cards.shop_id]
  shop_role_ids int [ref: > roles.shop_id]
}

Enum role_type {
  manager
  assistant
  stamper
  viewer
}

Table roles {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  created_by int [ref: > users.id]
  user_id int [ref: > users.id]
  role_type role_type
  permission_settings varchar
  shop_id int [ref: > shops.id]
}

Table memberships {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  user_id int [ref: > users.id]
  role_type role_type
  points int
  shop_id int [ref: > shops.id]
}

Table rewards {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  edited_by int [ref: > users.id]
  created_by int [ref: > users.id]
  cost int
  quantity int
  group_limit int
  user_limit int // how to track usage of limit and resets?
  schedule_settings json [note: '{
    limit_reset: {schedule, limit_type: group|user|both}[],
    quantity_renewal: {schedule, renewal_quantity: int}[],
    availability: {schedule}[],
  }']
  expiry_date timestamp
  is_group_reward bool
  can_contribute bool
  shop_id int [ref: > shops.id]
  redemption_ids int [ref: > redemptions.id]
  history json [note: '{
    datetime: { // only add new history item if something has changed, and only include changed items
      name,
      summary,
      color,
      icon,
      cost,
    }
  }']
}

Table redemptions {
  id int [pk, increment]
  created_at timestamp
  user_id int [ref: > users.id]
  reward_id int [ref: > rewards.id]
  reward_version datetime
}

Enum membership_mode {
  personal
  invite
  public
}
Enum stamp_system_type {
  self
  members
  stampers
}

Enum card_type {
  weekly
  daily
  todo

  scheduled
  frequency
  target
}

Table cards {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  created_by int [ref: > users.id]
  privacy_mode privacy_setting
  shop_id int [ref: > shops.id]
  task_ids int [ref: > tasks.id]
  type card_type
}

Table tasks {
  id int [pk, increment]
  edited_at timestamp
  created_at timestamp
  created_by int [ref: > users.id]
  point_value int
  point_value_partial int
  allows_partial bool
  allows_multiple bool // show as x2, x3, etc. text in corner
  max_multiple int
  availability_settings json [note: '{
    must_stamp_during bool
    schedules {}
  }']
  frequency_settings json [note: '{ // ex. twice every three days, five times every two weeks
    quantity
    time_unit_quantity
    time_unit day|week|month|year
  }']
  target int
  group_target int
  bonus_values json [note: '{
    reach_total int;
    streaks [{length: int, points: int, is_repeatable: bool}],
    milestones: [{name: varchar, points: int, quantity: int, }]
    {
      name,
      points,
      bonus_type streak|milestone|target
      quantity,
      is_repeatable,
      is_for_group
      group_streak_min_members
    }
  }']
  deadline timestamp
}

Enum stamp_status {
  pending
  partial
  complete
}

Table stamps {
  id int [pk, increment]
  created_at datetime [default: `now()`]
  date datetime
  time timestamp
  task_id int [ref: > tasks.id]
  user_id int [ref: > users.id]
  stamper_id int [ref: > users.id]
  status stamp_status
}
