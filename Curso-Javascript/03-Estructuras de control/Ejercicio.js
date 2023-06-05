// factorial-for.js
var y=1;
for(let x=10;x>=1;x--){
    y*=x

}
console.log(y)

//factorial-while.js
var y=1;
var x=10;
while(x>=1){
y*=x;
x--;
}
console.log(y)


var y=1;
var x=10;
//factorial-break.js
while(true){
    y*=x;
    x--;
    if(y==3628800)
    break
    }
console.log(y)