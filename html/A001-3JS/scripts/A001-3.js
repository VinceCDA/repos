"use strict"
// init variables
var decompte; // ref objet timer
var tpsEcoule = 0; // nbre secondes
// refs objets DOM
var chronoP = document.getElementById("chrono");
var btnStart = document.getElementById("btnStart");
var btnPause = document.getElementById("btnPause");
var btnStop = document.getElementById("btnStop");
(function () {
	btnStart.addEventListener("click", startChrono);
	btnStart.paramTps = tpsEcoule;
	btnPause.paramTps = tpsEcoule;
}());

function startChrono(e) {
	btnStart.removeEventListener("click", startChrono);
	btnStart.className = "invi";
	btnPause.className = "visi";
	btnPause.addEventListener("click",pauseChrono);
	btnStop.className = "visi";
	btnStop.addEventListener("click",stopChrono);
	// calcul de nombre heures, minutes et secondes écoulées
	var startTime = new Date();
	decompte = setInterval(function () {
		// 1- Convertir en secondes :
		var seconds = Math.round(
			(new Date().getTime() - startTime.getTime()) / 1000
			+ e.target.paramTps);
			console.log(e.target.paramTps) // e représente l'event déclencheur
		// e.target représente l'objet déclencheur
		// ici : bouton start ou bouton pause
		// (cette propriété a été ajoutée aux boutons)
		// 2- Extraire les heures :
		var hours = parseInt(seconds / 3600);
		seconds = seconds % 3600; // secondes restantes
		// 3- Extraire les minutes:
		var minutes = parseInt(seconds / 60);
		seconds = seconds % 60; // secondes restantes
		// 4- afficher dans le span
		chronoP.innerHTML = ajouteUnZero(hours)
			+ ":" + ajouteUnZero(minutes)
			+ ":" + ajouteUnZero(seconds);
		// 5- incrémenter le nombre de secondes
		tpsEcoule += 1;
	}, 1000); // fin de fonction anonyme dans setInterval()
}
function ajouteUnZero(param){
	if (param < 10) {
		return param = ""+0+param;
	}
	return param;
}
function pauseChrono(){
	clearInterval(decompte);
	btnStart.addEventListener("click", startChrono);
	btnStart.className = "visi";
	btnStart.paramTps = tpsEcoule;
	btnPause.className = "invi";
	btnPause.removeEventListener("click",pauseChrono);
}
function stopChrono(){
	clearInterval(decompte);
	btnStart.addEventListener("click", startChrono);
	btnStart.className = "visi";
	btnPause.className = "invi";
	btnPause.removeEventListener("click",pauseChrono);
	btnStop.className = "invi";
	btnStop.removeEventListener("click",stopChrono);
	tpsEcoule = 0;
	btnStart.paramTps = 0;
	chronoP.innerHTML = "00:00:00";
}


