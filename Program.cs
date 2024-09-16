//var
string enjoymentLevel = "";
string stadiumPick = "";
string gameP =  "";

// main
GetEnjoymentLevel();
GetStadiumRecommendation();
GetGameRecommendation();
DisplayStadiumDetails();
//end main

//method GetEnjoymentLevel
string GetEnjoymentLevel()
{
System.Console.WriteLine("What is your preffered level of enjoyment? Boring, Average, Fun, or Epic?");
enjoymentLevel = Console.ReadLine().ToLower();
if(enjoymentLevel == "boring"){
return enjoymentLevel;
}
else if(enjoymentLevel == "average"){
    return enjoymentLevel;
}
else if (enjoymentLevel =="fun"){
    return enjoymentLevel;
}
else if (enjoymentLevel =="epic"){
return enjoymentLevel;
}
else{
    System.Console.WriteLine("Please enter Boring, Average, Fun, or Epic");
    return GetEnjoymentLevel();
}
}

string GetStadiumRecommendation()
{
if(enjoymentLevel == "boring"){
    stadiumPick = "Neyland Stadium";
}
else if(enjoymentLevel == "average"){
    stadiumPick = "Jordan-Hare Stadium";
}
else if(enjoymentLevel == "fun"){
    stadiumPick = "Tiger Stadium";
}
else if(enjoymentLevel == "epic"){
    stadiumPick = "Saban Field at Bryant-Denny Stadium";
}
return stadiumPick;
}

string GetGameRecommendation()
{
if(stadiumPick == "Neyland Stadium"){
    gameP = "Tennesee vs Kent State";
}
else if(stadiumPick == "Jordan-Hare Stadium"){
    gameP = "Auburn vs Kentucky";
}
else if(stadiumPick == "Tiger Stadium"){
    gameP = "LSU vs Alabama";
}
else if(stadiumPick == "Saban Field at Bryant-Denny Stadium"){
    gameP = "Alabama vs Auburn";
}
return gameP;
}
void DisplayStadiumDetails()
{
    System.Console.WriteLine($"You should attend {stadiumPick} for the game {gameP}");
}



