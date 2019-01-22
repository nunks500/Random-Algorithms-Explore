function optionalPow(e, a, b) {
        if(e.keyCode == 13) //if user presses enter
          return Math.pow(a, b)
        else if(e.keyCode == 8) //user presses backspace
          return Math.pow(b, a)
}

console.log('Yes or No?');
document.addEventListener("keydown", function (e) {
           a = 2;
           b = 3; //for example
           optionalPow(e, a, b);
        });

function fixage(a) {
        var stringToReturn = "";
  
        for(var i = 0;i < a.length; i++){
          if(a[i] > 18 && a[i] < 60 && typeof foo === "number"){
            if(i + 1 != a.length)
              stringToReturn += a[i] + ",";
            else
              stringToReturn += a[i];
          }
        }
  
        if(stringToReturn == null)
          return "NA";        
}

function commonDigits(a, b) {
    var countDigitsInitialize = [0, 0, 0, 0, 0, 0, 0, 0, 0];
  
     for(var i = 0;i < b.length;i++)
       {
         var stringToIterate = b[i].toString();
           for(var j = 0;j < stringToIterate.length;j++)
            {
              countDigitsInitialize[stringToIterate.charAt(j)]++;
            }

       }
  
   let max = indexOfMax(countDigitsInitialize);
   return max;
  
}

function indexOfMax(arr) {
    if (arr.length === 0) {
        return -1;
    }

    var max = arr[0];
    var maxIndex = 0;

    for (var i = 1; i < arr.length; i++) {
        if (arr[i] >= max) {
            maxIndex = i;
            max = arr[i];
        }
    }

    return maxIndex;
}

function sumDigits(a, b) {
  var arr = [];
    for(var i = 0;i < b.length; i++)
      {
         var stringToIterate = b[i].toString();
         var sum = 0;
         for(var j = 0;j < stringToIterate.length;j++)
            {
              sum += parseInt(stringToIterate.charAt(j));
            }
        arr.push(sum);
      }
  
   let max = indexOfMax(arr);
   return max;
}
