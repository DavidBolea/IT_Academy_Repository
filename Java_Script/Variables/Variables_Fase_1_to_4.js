
console.log("");
console.log("// -------------------------Variables Fase 1-------------");
var nom='David';
var cognom='Bolea';
var segoncognom='Sancho';
var dia=23;
var mes=4;
var any=1973;
console.log(nom + ' ' + cognom + ' ' + segoncognom);
console.log(dia + '/' + mes + '/' + any);

console.log("");
console.log("// -------------------------Variables Fase 2-------------");
console.log("");
const any_1948=1948;
const periode_traspas=4;
var periode_anys=(any - any_1948) / periode_traspas;
var n = periode_anys.toString();
var no_anys_de_traspas = n.substr(0,1);
console.log('Anys de Traspàs (sense comptar 1948): ' + no_anys_de_traspas); 

console.log("");
console.log("// -------------------------Variables Fase 3-------------");
console.log("");
var any_T = any_1948;
var es_traspas_1973 = false;
var si_es_traspas = 'El meu any de naixement ES de traspàs';
var no_es_traspas = 'El meu any de naixement NO es de traspàs';
function f_traspas(name){ //función no necesaria pero incluida para saber como se declara en JavaScript
    console.log('la vaiable bol es :' + es_traspas_1973);
}
for(i = 0 ; i < no_anys_de_traspas ; i++){
    any_T = any_T + periode_traspas;

    console.log('Any de Traspàs: '+ any_T);

    if (any_T == any) {
        es_traspas_1973 = true;
    } else {
        es_traspas_1973 = false;
    }
}
if (es_traspas_1973 == true) {
    f_traspas(si_es_traspas);// llama a la función
} else {
    f_traspas(no_es_traspas);
}

console.log("");
console.log("// -------------------------Variables Fase 4-------------");
console.log("");
var nom_complert = nom + ' ' + cognom + ' ' + segoncognom;
var data_complerta = dia + '/' + mes + '/' + any;
console.log('El meu nom es: ' + nom_complert);
console.log('Vaig néixer el: ' + data_complerta);
if (es_traspas_1973 == true) {
    console.log( si_es_traspas);
} else {
    console.log( no_es_traspas);
}

