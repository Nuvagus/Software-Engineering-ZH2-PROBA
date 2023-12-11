function FahrenheitToCelsius(f) {
	return (f * 5) / 9;
}
var celsiusTemp = FahrenheitToCelsius(respone.current.temperature);
var celsiusTempFeels = FahrenheitToCelsius(respone.current.feels_like);

fetch('https://ai-weather-by-meteosource.p.rapidapi.com/find_places?text=fishermans%20wharf&language=en', {
	"method": "GET",
	"headers": {
		'X-RapidAPI-Key': 'bf18c630e0mshddc88b44f25633cp1cb1adjsn748656c957d9',
		'X-RapidAPI-Host': 'ai-weather-by-meteosource.p.rapidapi.com'
	}
}).then(response => response.json())
	.then(response => {
		console.log(response);

		document.getElementById('summary').innerHTML = response.current.summary;
		document.getElementById('temp').innerHTML = celsiusTemp
		document.getElementById('tempFeelsLike').innerHTML = celsiusTempFeels;
	}).catch(err => {
		console.log(err);
	})