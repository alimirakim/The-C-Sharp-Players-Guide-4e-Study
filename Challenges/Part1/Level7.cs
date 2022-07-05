using System;
namespace Template;

/// <summary>
/// LEVEL 7: Math
/// </summary>
public static class Level7
{
  public static void CallAll()
  {
    TheTriangleFarmer();
    TheFourSistersAndTheDuckbear();
    TheDominionOfKings();
  }

/// <summary>
  /// Challenge 1/3: The Triangle Farmer
  ///<br/> TODO 
  ///<br/> 
  ///<br/> *Area = base x height / 2*
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Write a program that lets you input the triangle's base size and height.
  ///<br/> [] Compute the area of a triangle by turning the above equation into code.
  ///<br/> [] Write the result of the computation.
  /// </summary>
  public static void TheTriangleFarmer()
  {
    Utils.WriteTitle("The Triangle Farmer");


  }

  // *************************************************************************************************

  /// <summary>
  /// Challenge 2/3: The Four Sisters and the Duckbear
  ///<br/> TODO
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Create a program that lets the user enter the number of chocolate eggs gathered that day.
  ///<br/> [] Using `/` and `%`, compute how many eggs each sister should get and how many are left over for the duckbear.
  ///<br/> [] Answer this question: What are three total egg counts where the duckbear gets more than each sister does? Use the program you created to help you find the answer. 
  /// </summary>
  public static void TheFourSistersAndTheDuckbear()
  {
    Utils.WriteTitle("The Four Sisters And The Duckbear");
  }

  // *************************************************************************************************

  /// <summary>
  /// Challenge 3/3: The Dominion of Kings
  ///<br/> Three kings, Melik, Casik, and Balik, are sitting around a table, debating who has the greatest kingdom among them. Each king rules an assortment of provinces, duchies, and estates. Collectively, they agree to a point system that helps them judge whose kingdom is greatest: Every estate is worth 1 point, every duchy is worth 3 points, and every province is worth 6 points. They just need a program that will allow them to enter their current holdings and compute a point total.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Create a program that allows the user to enter how many provinces, duchies, and estates they have.
  ///<br/> [] Add up the user's total score, giving 1 point per estate, 3 per duchy, and 6 per province.
  ///<br/> [] Display the point total to the user.
  /// </summary>
  public static void TheDominionOfKings()
  {
    Utils.WriteTitle("TheDominionOfKings");


  }
}