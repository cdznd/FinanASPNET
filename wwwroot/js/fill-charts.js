async function fillCharts() {

    //MyAPIs
    var categoriaListUrl = "https://localhost:44356/api/Categoria/List";
    //var lancamentoListUrl = "https://localhost:44356/api/Lancamento/List";

    var lancamentosCategoriaByIdUrl = "https://localhost:44356/api/Categoria/Search/{id}/Lancamentos"

    var CategoriaNames = [];
    var CategoriaValues = [];

    //CATEGORY CHARTS

    fetch(categoriaListUrl, { method: "GET" })
        .then(reponse => reponse.json())
        .then(data => {

            data.forEach(categoria => {

                var categoriaId = categoria.id
                var categoriaName = categoria.nome
                var url = `https://localhost:44356/api/Categoria/Search/${categoriaId}/ListLancamentosValueByConta`

                fetch(url, { method: "GET" })
                    .then(response => response.json())
                    .then(data => {

                        CategoriaNames.push(categoriaName);
                        CategoriaValues.push(data);

                    })

            });

        }).catch(error => console.log(error));

    //LINEAR CHART

    var Months = ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'];
    var MonthValue = [0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0]

    var MonthNumber = 0;

    for (var month of Months) {

        MonthNumber++;
        var url = `https://localhost:44356/api/Lancamento/Search/Month/${MonthNumber}`;

        await fetch(url, { method: "GET" })
            .then(response => response.json())
            .then(data => {

                for (var lancamento of data) {

                    MonthValue[MonthNumber - 1] = MonthValue[MonthNumber - 1] + lancamento.valor;

                }

            }).catch(error => console.log(error));

    }

    //createPolarAreaChart(CategoriaNames, CategoriaValues)
    createPieChart(CategoriaNames, CategoriaValues)
    //createDoughnutChart(CategoriaNames, CategoriaValues)
    createBarChart(CategoriaNames, CategoriaValues)
    createLineChart(Months, MonthValue)

}