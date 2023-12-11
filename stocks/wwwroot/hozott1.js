function getRandomInt(min, max) {
	return Math.floor(Math.random() * (max - min)) + min;
}
var randomNum = getRandomInt(0, 20);

fetch('https://apistocks.p.rapidapi.com/daily?symbol=AAPL&dateStart=2021-07-01&dateEnd=2021-07-31', {
	"method": "GET",
	"headers": {
		'X-RapidAPI-Key': 'bf18c630e0mshddc88b44f25633cp1cb1adjsn748656c957d9',
		'X-RapidAPI-Host': 'apistocks.p.rapidapi.com'
	}
}).then(response => response.json())
	.then(response => {
		console.log(response);

		document.getElementById('stockname').innerHTML = response.Metadata.Symbol;
		document.getElementById('date').innerHTML = response.Results[randomNum].Date;
		document.getElementById('price').innerHTML = response.Results[randomNum].Open;
	}).catch(err => {
		console.log(err);
	})