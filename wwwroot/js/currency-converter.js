//API PARA COTAÇÃO DE MOEDA
//https://docs.awesomeapi.com.br/api-de-moedas
//var url = "https://economia.awesomeapi.com.br/json/all/USD-BRL,CAD-BRL,ARS-BRL,EUR-BRL,CHF-BRL,BTC-BRL,LTC-BRL,ETH-BRL"

async function currencyConverter() {

    var url = "https://economia.awesomeapi.com.br/json/all/USD-BRL,CAD-BRL,ARS-BRL,EUR-BRL,CHF-BRL,BTC-BRL,LTC-BRL,ETH-BRL"
    var currencyValue = [];

    await fetch(url, { method: "GET" })
        .then(response => response.json())
        .then(data => {

            var USD = data.USD.ask;
            var CAD = data.CAD.ask;
            var ARS = data.ARS.ask;
            var EUR = data.EUR.ask;
            var CHF = data.CHF.ask;
            var BTC = data.BTC.ask;
            var LTC = data.LTC.ask;
            var ETH = data.ETH.ask;

            currencyValue.push(USD, CAD, ARS, EUR, CHF, BTC, LTC, ETH);

        })

    return currencyValue;

    }

