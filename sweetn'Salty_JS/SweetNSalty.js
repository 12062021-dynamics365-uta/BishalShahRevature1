let Sweet = 0; 
let Salty = 0; 
let sweetNSalty = 0; 
//thanks to Kevin Lee                            
var array = new Array();                           


//Number startng at 1 and goes to 1000 by incrementing by single number.
for (var i = 1; i <= 1000; i++)
{
    //if multiple of both 3 and 5 returns SweetNSalty
    if (i % 3 == 0 && i % 5 == 0)
    {
        //appends the string value and pushes it as the new value if the expression is true
        array.push("SweetNSalty" + " ");
        sweetNSalty++;
    }

    ///if multiple of 5 returns sweet and appens to the count
    else if (i % 5 == 0)
   {
        array.push("Salty, " + " ");
        Salty++;                   
    }

    //if multiple of 3 returns sweet and appens to the count
    else if (i % 3 == 0)
    {
        array.push("Sweet, " + " ");
        Sweet++;                  
    }

    //Any other numbers will count as numbers.
    else
    {
        array.push(i + " ");                    
    }

    //Every 20 numbers will seperate the group.
    if (i % 20 == 0)
    {
        //breaks the array if the expression is true and starts a new array
        console.log(array.toString());
        array = [];
    }
}        
//Count how many time were printed by each.
console.log("Total number of times SweetNSalty was printed: " + sweetNSalty);
console.log("Total number of times Salty was printed: " + Salty);
console.log("Total number of times Sweet was printed: " + Sweet);