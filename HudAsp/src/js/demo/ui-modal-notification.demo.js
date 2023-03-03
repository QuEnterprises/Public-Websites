/*
Template Name: HUDASP - Responsive Bootstrap 5 Admin Template
Version: 1.9.0
Author: Sean Ngu
Website: http://www.seantheme.com/hud-asp/
*/

var handleToastsInit = function() {
	$('[data-init="toast"]').toast('show');
};

var handleToastToggle = function() {
	$(document).on('click', '[data-toggle="toast"]', function(e) {
		e.preventDefault();
		
		var targetElm = $(this).attr('data-target');
		$(targetElm).toast('show');
	});
};


/* Controller
------------------------------------------------ */
$(document).ready(function() {
	handleToastsInit();
	handleToastToggle();
});