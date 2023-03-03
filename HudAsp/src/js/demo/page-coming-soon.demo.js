/*
Template Name: HUDASP - Responsive Bootstrap 5 Admin Template
Version: 1.9.0
Author: Sean Ngu
Website: http://www.seantheme.com/hud-asp/
*/

var handleRenderCountdownTimer = function() {
	var newYear = new Date();
	newYear = new Date(newYear.getFullYear() + 1, 1 - 1, 1);
	$('#timer').countdown({until: newYear});
};


/* Controller
------------------------------------------------ */
$(document).ready(function() {
	handleRenderCountdownTimer();
});