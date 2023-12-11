function FahrenheitToCelsius(f) {
	return (f * 5) / 9;
}


fetch('https://ai-weather-by-meteosource.p.rapidapi.com/current?lat=37.81021&lon=-122.42282&timezone=auto&language=en&units=auto', {
	"method": "GET",
	"headers": {
		'X-RapidAPI-Key': 'bf18c630e0mshddc88b44f25633cp1cb1adjsn748656c957d9',
		'X-RapidAPI-Host': 'ai-weather-by-meteosource.p.rapidapi.com'
	}
}).then(response => response.json())
	.then(response => {
		console.log(response);
		var celsiusTemp = FahrenheitToCelsius(response.current.temperature);
		var celsiusTempFeels = FahrenheitToCelsius(response.current.feels_like);
		document.getElementById('summary').innerHTML = response.current.summary;
		document.getElementById('temp').innerHTML = celsiusTemp
		document.getElementById('tempFeels').innerHTML = celsiusTempFeels;
	}).catch(err => {
		console.log(err);
	})
