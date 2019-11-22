console.log("");
console.log("-------------------------lletres Repetides Fase 1-------------");
console.log("");
var nom="David";
array_lletresNom = new Array(nom.length);
for(i = 0 ; i < nom.length ; i++ ){
array_lletresNom[i]=nom.substr(i,1);
console.log(i + " = " + array_lletresNom[i]);
}


console.log("");
console.log("-------------------------lletres Repetides Fase 2-------------");
console.log("");
var lst_Nom  = array_lletresNom.slice(); // en JavaScript creo que no hay List....lo paso a otro array

for(i = 0; i < lst_Nom.length; i++){ //comprueba si es vocal o consonante

    letra=lst_Nom[i].toLowerCase();
    if((letra=="a") || (letra=="e") || (letra=="i") || (letra=="o") || (letra=="u")){//Condición con "||" = OR

        console.log(lst_Nom[i] + " Vocal");
    }
    else{
        console.log(lst_Nom[i] + " Consonant");
    }
    if (isNaN(lst_Nom[i])){
    }else{
        console.log("Els noms de persones no contenen números");

    }
}


console.log("");
console.log("// -------------------------lletres Repetides Fase 3-------------");
console.log("");
var dict_Name = new Map(); // declara dictionary de las letras 1x1
var dict_Lletres_Repetides = new Map(); // declara dictionary con el numero de veces q las letras están repetidas
   
lst_Nom.forEach(function(valor, clave) {//pasa los datos de Array a dictionary
        dict_Name.set(clave,valor);
        console.log(clave + " " + valor);
});

console.log("");
 
var indices = [];
function busca_Lletres(cadenas, lletra) { //función que busca y cuenta letras repetidas en una cadena.
    for(var i = 0; i < cadenas.length; i++) {
        if (cadenas[i].toLowerCase() === lletra) indices.push(i);
    }
    return indices.length;
}
for (var [clave, valor] of dict_Name) {//bucle que recorre todos los elementos de "dict_Name" y registra las letras repetidas en dict_lletres_Repetides
    var x = busca_Lletres(nom, valor.toLowerCase());
    dict_Lletres_Repetides.set(clave,x);
    indices = []
}
dict_Lletres_Repetides.forEach(function(valor, clave) {//imprime los diccionarios
    console.log("La lletra '"+ dict_Name.get(clave) + "' està " + valor + " cop/s repetida.");
});


console.log("");
console.log("// -------------------------lletres Repetides Fase 4-------------");
console.log("");
var indexName=dict_Name.size
dict_Name.set(indexName," ");
var cognom="Bolea";
var dict_Surname = new Map();
for(i = 0; i < cognom.length; i++){
    dict_Surname.set(i,cognom[i]);
}
dict_Surname.forEach(function(valor, clave){//imprime el diccionario 'Surname'
    console.log(clave + " " + valor);
});
console.log("");
var f=0;
var fullName=new Map(); // rellena el nuevo diccionario 'fullName con el nombre
dict_Name.forEach(function(valor,clave){
    fullName.set(clave,valor);
    f += 1;
});
dict_Surname.forEach(function(valor){// rellena el nuevo diccionario 'fullName con el apellido
    fullName.set(f,valor);
    f += 1
});
var string_fullName="fullName: ['"
fullName.forEach(function(valor, clave){//imprime el diccionario 'fullName' en horizontal
    string_fullName += valor + "','";
});
string_fullName = string_fullName.substr(0,string_fullName.length-2);
string_fullName += "]";
console.log(string_fullName);
