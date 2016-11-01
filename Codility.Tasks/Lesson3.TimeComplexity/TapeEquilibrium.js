var TapeEquilibrium =
    {
        solution: function (A) {
         // write your code in JavaScript (Node.js 6.4.0)

            let sum = A.reduce((x, y) =>x + y, 0);

            return sum > 0;
        }
    } 