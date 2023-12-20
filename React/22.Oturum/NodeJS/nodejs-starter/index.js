console.log("Merhaba"); 
//NodeJS, makinanmızda yazdığımız javaScript kodlarını tarayıcı tarafında okuyabilmemiz için tarayıcının anlayabileceği dile çevrilmesini sağlar.
//Node sayesinde bilgisayarımız Javascript'i çalıştırabiliyor.
//Npm, nodeJs'in paketlerinin yönetildiği bir alandır.
//'npm init' komutu ile nodejs projesi başlatılır.
//JS type-safe değildir!
var text = "Merhaba, Tobeto";
console.log(text);
text = 50;
console.log(text);
text=true;
console.log(text);

// EcmaScript => javascriptin eski yapısını modern yapılara benzetmek için geliştirilmiştir.

console.log(hello);
var hello = "Merhaba";

//var number = 10;
//if (number > 5){
        //var newVariable ="Hello";
//}
//console.log(newVariable);

// let & const
// let => let var'ın problemlerini ortadan kaldırır. Daha modern dillere

//let number = 10;
//if (number > 5){
//        let newVariable ="Hello";
//}
//console.log(newVariable);

// ES6 2015 - ES2016 - ES2017 - ES2018

function topla(sayi1, sayi2){
    return sayi1 + sayi2;
}

//console.log(topla(5,10));
//console.log(topla()); // Not a number
//console.log(topla(1));
//console.log(topla(1,"5"));
//console.log(topla("5",1,5,4,6,7,8));

// Arrow Function

const toplaFunction = (sayi1,sayi2) => sayi1+sayi2; // tek satır kullanımı için
const toplaFunction2 = (sayi1,sayi2) => {           // multiple kullanım için
    // bla...
    // blaa...
    return sayi1+sayi2;
}
console.log(toplaFunction(1,5));

console.log(toplaFunction(5,10));
console.log(toplaFunction()); // Not a number
console.log(toplaFunction(1));
console.log(toplaFunction(1,"5"));
console.log(toplaFunction("5",1,5,4,6,7,8));
// const => SABİT
const PI = 3.14;

console.log("**************")

//CB (callback) Function =>
//callback functioon, js de çok fazla aktif olarak kullanılır.
//callback fonksiyon , bir fonksiyon içinde kullanabildiğimiz başka bir fonksiyon.

let list = [5,10,15,20]

//1. parametre eleman /e
//2. parametre index  /i 
//list.forEach( (element,index) => { 
    //console.log(element,index);
//});
//birinci parametreyi almadan ikinci parametreyi alamayız.
//

// map-filter-reduce => önemli 3 fonksiyon

// map =>
//let newList = list.map((element) => {return element * 2});
//console.log(newList);

// filter =>
//new filteredList = list.filter((element) => {return element >= 10});
//console.log(filteredList);

// reduce =>
let value = list.reduce((previous,next) => {
    return previous + next; 
} ,0); // 0
console.log(value);

//npm
//dependencies
//nodemon
//devDependencies //npm install nodemon --save-dev
//Node package excecute npx
