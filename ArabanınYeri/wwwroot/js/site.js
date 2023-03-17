// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {

	let theme = 0;

	$(".theme").click(function () {
		$("body").css("transition", ".5s");

		theme++;

		if (theme > 1) {
			theme = 0;
		}

		if (theme == 0) {
			$(".fa-sun").addClass("fa-moon");
			$(".fa-sun").removeClass("fa-sun");
			$("body").css("backgroundColor", "white");
			$("body").css("color", "black");
			$(".yazi").css("color", "black");
		}

		if (theme == 1) {
			$(".fa-moon").addClass("fa-sun");
			$(".fa-moon").removeClass("fa-moon");
			$("body").css("backgroundColor", "rgba(40,40,40)");
			$("body").css("color", "white");
			$(".yazi").css("color", "white");
		}
	});

});