/// <summary>
/// LEVEL 9: Decision Making
/// </summary>
public static class Part1Level9
{
  public static void CallAll()
  {
    RepairingTheClockTower();
    Watchtower();
  }

  /// <summary>
  /// Challenge 1/2: Repairing the Clocktower
  ///<br/> The recent attacks damaged the great Clocktower of Consolas. The citizens of Consolas have repaired most of it, except one piece that requires the steady hand of a Programmer. It is the part that makes the clock tick and tock. Numbers flow into the clock to make it go, and if the number is even, the clock's pendulum should stick to the left. If the number is odd, the pendulum should tock to the right. Only a Programmer can recreate this critical element of the clock to make it work again.
  ///<br/> 
  ///<br/> **Objectives:**
  ///<br/> [] Take a number as input from the console.
  ///<br/> [] Display the word "Tick" if the number is even. Display the word "Tock" if the number is odd.
  ///<br/> - Hint: Remember that you can use the remainder operator to determine if a number is even or odd.
  /// </summary>
  public static void RepairingTheClockTower()
  {
    Utils.WriteTitle("Repairing The Clock Tower");


  }

  /// <summary>
  /// Challenge 2/2: Watchtower
  ///<br/> There are watchtowers in the region around Consolas that can alert you when an enemy is spotted. With some help from you, they can tell you which direction the enemy is from the watchtower.
  ///<br/> 
  ///<br/> **Image:**
  ///<br/>       x< 0  x= 0  x> 0
  ///<br/>      |----|-----|----|
  ///<br/> y> 0 | NW |  N  | NE |
  ///<br/> y= 0 | W  |  !  |  E |
  ///<br/> y< 0 | SW |  S  | SE |
  ///<br/>      |----|-----|----|
  ///<br/>     
  ///<br/> **Objectives:**
  ///<br/> [] Ask the user for an `x` value and a `y` value. These are coordinates of the enemy relative to the watchtower's location.
  ///<br/> [] Using the image above, `if` statements, and relational operators, display a message about what direction the enemy is coming from. For example, "The enemy is to the northwest!" or "The enemy is here!"
  /// </summary>
  public static void Watchtower()
  {
    Utils.WriteTitle("Watchtower");


  }

}