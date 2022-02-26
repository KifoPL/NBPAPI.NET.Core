# Wygląd zapytań:

## Tabele

### Typ `A`

```json
[
	{
		"table": "A",
		"no": "039/A/NBP/2022",
		"effectiveDate": "2022-02-25",
		"rates": [
			{ "currency": "bat (Tajlandia)", "code": "THB", "mid": 0.1283 }
		]
	}
]
```

### Typ `B`

```json
[
	{
		"table": "B",
		"no": "008/B/NBP/2022",
		"effectiveDate": "2022-02-23",
		"rates": [
			{ "currency": "balboa (Panama)", "code": "PAB", "mid": 3.9937 }
		]
	}
]
```

### Typ `C`

```json
[
	{
		"table": "C",
		"no": "039/C/NBP/2022",
		"tradingDate": "2022-02-24",
		"effectiveDate": "2022-02-25",
		"rates": [
			{ "currency": "euro", "code": "EUR", "bid": 4.648, "ask": 4.7418 }
		]
	}
]
```

## Waluty

### Typ `A`

```json
{
	"table": "A",
	"currency": "euro",
	"code": "EUR",
	"rates": [
		{ "no": "039/A/NBP/2022", "effectiveDate": "2022-02-25", "mid": 4.6608 }
	]
}
```

### Typ `B`

```json
{
	"table": "B",
	"country": "Monako",
	"symbol": "978",
	"currency": "euro",
	"code": "EUR",
	"rates": [
		{ "no": "10/B/NBP/2004", "effectiveDate": "2004-04-28", "mid": 4.7805 }
	]
}
```

### Typ `C`

```json
{
	"table": "C",
	"currency": "euro",
	"code": "EUR",
	"rates": [
		{
			"no": "039/C/NBP/2022",
			"effectiveDate": "2022-02-25",
			"bid": 4.648,
			"ask": 4.7418
		}
	]
}
```

## Parametry zapytań o kursy walut

`{table}` - typ tabeli (`A`, `B`, `C`)
`{code}` - kod waluty (standard `ISO 4217`)
`{topCount}` - liczba określająca maksymalną liczność zwracanej serii danych
`{date}`, `{startDate}`, `{endDate}` - daty w formacie `ISO 8601`

## Aktualnie obowiązująca tabela kursów typu `{table}`

`http://api.nbp.pl/api/exchangerates/tables/a?format=json`

Wygląd tabeli:

## Seria ostatnich `{topCount}` tabel kursów typu `{table}`

Wygląd:

```json
[
	{
		"table": "B",
		"no": "006/B/NBP/2022",
		"effectiveDate": "2022-02-09",
		"rates": [
			{
				"currency": "afgani (Afganistan)",
				"code": "AFN",
				"mid": 0.042327
			}
		]
	},
	{
		"table": "B",
		"no": "007/B/NBP/2022",
		"effectiveDate": "2022-02-16",
		"rates": [
			{
				"currency": "afgani (Afganistan)",
				"code": "AFN",
				"mid": 0.04306
			}
		]
	},
	{
		"table": "B",
		"no": "008/B/NBP/2022",
		"effectiveDate": "2022-02-23",
		"rates": [
			{
				"currency": "afgani (Afganistan)",
				"code": "AFN",
				"mid": 0.043601
			}
		]
	}
]
```

## Tabela kursów typu `{table}` opublikowana w dniu dzisiejszym (albo `404`)

```json
[
	{
		"table": "C",
		"no": "039/C/NBP/2022",
		"tradingDate": "2022-02-24",
		"effectiveDate": "2022-02-25",
		"rates": [
			{
				"currency": "dolar amerykański",
				"code": "USD",
				"bid": 4.1695,
				"ask": 4.2537
			}
		]
	}
]
```

```json
{
	"table": "A",
	"currency": "funt szterling",
	"code": "GBP",
	"rates": [
		{
			"no": "030/A/NBP/2022",
			"effectiveDate": "2022-02-14",
			"mid": 5.4645
		},
	]
}
```
