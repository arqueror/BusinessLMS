﻿
$(document).ready(function () {
	/******************************************/
	var date = new Date();
	var d = date.getDate();
	var m = date.getMonth();
	var y = date.getFullYear();

	var calendar = $('#calendar').fullCalendar({
		theme: true,
		selectable: true,
		selectHelper: true,
		editable: true,
		header: {
			left: 'prev,next today',
			center: 'title',
			right: 'month,agendaWeek,agendaDay'
		},
		select: function (start, end, allDay) {
			var title = prompt('Event Title:');
			if (title) {
				calendar.fullCalendar('renderEvent',
					{
						title: title,
						start: start,
						end: end,
						allDay: allDay
					},
					true // make the event "stick"
				);
			}
			calendar.fullCalendar('unselect');
		},
		events: "/Calendar/GetEvents/All",
		loading: function (bool) {
			if (bool)
				$("#calendar").showLoading({ vPos: "top" });
			else
				$("#calendar").hideLoading();
		}
	});

});