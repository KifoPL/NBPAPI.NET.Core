# NBPAPI.NET.Core

<table>
<tbody>
<tr>
<td><a href="#currencyrate">CurrencyRate</a></td>
<td><a href="#exchangerates">ExchangeRates</a></td>
</tr>
<tr>
<td><a href="#rate">Rate</a></td>
<td><a href="#table">Table</a></td>
</tr>
<tr>
<td><a href="#goldrate">GoldRate</a></td>
<td><a href="#tablerate">TableRate</a></td>
</tr>
<tr>
<td><a href="#nbpapi">NbpApi</a></td>
</tr>
</tbody>
</table>


## CurrencyRate

Rate retrieved in single-currency rate requests.


## ExchangeRates

Class containing definitions of


## Rate

Definition of single-currency exchange rate table


## Table

Definition of exchange rate table


## GoldRate

Price of 1 kg of gold in PLN


## TableRate

Rate retrieved in tables request


## NbpApi

Entry point for interaction with the library.

### GetCurrenciesAsync(tableCode, currencyCode, startDate, endDate)

Gets exchange rates from PLN to currencyCode from startDate to endDate (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPAPI.NET.Core.Enums.TableType*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| startDate | *System.DateTime*<br>Start date. |
| endDate | *System.DateTime*<br>End date. |

#### Returns

Async XML/JSON result from NBP API.

### GetCurrenciesAsync(tableCode, currencyCode, topCount)

Gets last topCount exchange rates from PLN to currencyCode (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPAPI.NET.Core.Enums.TableType*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| topCount | *System.Int32*<br>Amount of exchange rates to return. |

#### Returns

Async XML/JSON result from NBP API.

### GetCurrencyAsync(tableCode, currencyCode, fromToday)

Gets current Exchange rate from PLN to currencyCode (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPAPI.NET.Core.Enums.TableType*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| fromToday | *System.Boolean*<br>`true` if you want table specifically from today (may return null), `false` if currently effective. |

#### Returns

Async result from NBP API.

### GetCurrencyAsync(tableCode, currencyCode, date)

Gets current Exchange rate from PLN to currencyCode published at date (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPAPI.NET.Core.Enums.TableType*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| date | *System.DateTime*<br>The date. |

#### Returns

Async XML/JSON result from NBP API.

### GetGoldPriceAsync(fromToday)

Gets current gold price asynchronously.

| Name | Description |
| ---- | ----------- |
| fromToday | *System.Boolean*<br>`true` if you want table specifically from today (may return null), `false` if currently effective. |

#### Returns

Gold price.

### GetGoldPriceAsync(date)

Gets the gold price published at date asynchronously.

| Name | Description |
| ---- | ----------- |
| date | *System.DateTime*<br>The date. |

#### Returns

Gold price, or null

### GetGoldPricesAsync(startDate, endDate)

Gets the gold prices asynchronously.

| Name | Description |
| ---- | ----------- |
| startDate | *System.DateTime*<br>The start date. |
| endDate | *System.DateTime*<br>The end date. |

#### Returns

List of gold prices.

### GetGoldPricesAsync(topCount)

Gets the gold prices asynchronously.

| Name | Description |
| ---- | ----------- |
| topCount | *System.Int32*<br>The top count. |

#### Returns

List of gold prices.

### GetTableAsync(tableCode, fromToday)

Gets current table of exchange rates (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPAPI.NET.Core.Enums.TableType*<br>Table Code (Capital A-C). |
| fromToday | *System.Boolean*<br>`true` if you want table specifically from today (may return null), `false` if currently effective. |

#### Returns

Async XML/JSON result from NBP API.

### GetTableAsync(tableCode, date)

Gets table of exchange rates from date (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPAPI.NET.Core.Enums.TableType*<br>Table Code (Capital A-C). |
| date | *System.DateTime*<br>the date. |

#### Returns

Async XML/JSON result from NBP API.

### GetTablesAsync(tableCode, startDate, endDate)

Gets tables from startDate to endDate (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPAPI.NET.Core.Enums.TableType*<br>Table Code (Capital A-C). |
| startDate | *System.DateTime*<br>Start date. |
| endDate | *System.DateTime*<br>End date. |

#### Returns

Async XML/JSON result from NBP API.

### GetTablesAsync(tableCode, topCount)

Gets last topCount of tables (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPAPI.NET.Core.Enums.TableType*<br>Table Code (Capital A-C). |
| topCount | *System.Int32*<br>Amount of tables to return. |

#### Returns

Async XML/JSON result from NBP API.

### Uri

http://api.nbp.pl/api/
