# NBPCurrencyAPILib

<table>
<tbody>
<tr>
<td><a href="#nbpapi">NBPAPI</a></td>
<td><a href="#tablecode">TableCode</a></td>
</tr>
</tbody>
</table>


## NBPAPI

Entry point for interaction with the library.

### Error(response)

| Name | Description |
| ---- | ----------- |
| response | *System.Net.Http.HttpResponseMessage*<br>The response. |

#### Returns

Error message with status code.

### GetCurrencies(tableCode, currencyCode, isJSON, endDate, startDate)

Gets exchange rates from PLN to currencyCode from startDate to endDate.

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| isJSON | *System.DateTime*<br>`true` if returned string will be JSON, `false` if XML. |
| endDate | *System.DateTime*<br>The end date. |
| startDate | *System.Boolean*<br>The start date. |

#### Returns

XML/JSON result from NBP API.

### GetCurrencies(tableCode, currencyCode, isJSON, topCount)

Gets current Exchange rate from PLN to currencyCode.

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| isJSON | *System.Int32*<br>`true` if returned string will be JSON, `false` if XML. |
| topCount | *System.Boolean*<br>The amount of currencies to get. |

#### Returns

XML/JSON result from NBP API.

### GetCurrenciesAsync(tableCode, currencyCode, startDate, endDate, isJSON)

Gets exchange rates from PLN to currencyCode from startDate to endDate (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| startDate | *System.DateTime*<br>Start date. |
| endDate | *System.DateTime*<br>End date. |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

Async XML/JSON result from NBP API.

### GetCurrenciesAsync(tableCode, currencyCode, topCount, isJSON)

Gets last topCount exchange rates from PLN to currencyCode (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| topCount | *System.Int32*<br>Amount of exchange rates to return. |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

Async XML/JSON result from NBP API.

### GetCurrency(tableCode, currencyCode, isJSON)

Gets current Exchange rate from PLN to currencyCode.

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

XML/JSON result from NBP API.

### GetCurrencyAsync(tableCode, currencyCode, isJSON)

Gets current Exchange rate from PLN to currencyCode (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

Async XML/JSON result from NBP API.

### GetCurrencyAsync(tableCode, currencyCode, isJSON, date)

Gets current Exchange rate from PLN to currencyCode from date (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| isJSON | *System.DateTime*<br>`true` if returned string will be JSON, `false` if XML. |
| date | *System.Boolean*<br>The date. |

#### Returns

Async XML/JSON result from NBP API.

### GetCurrencyToday(tableCode, currencyCode, isJSON)

Gets Exchange rate from PLN to currencyCode published today.

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML |

#### Returns

XML/JSON result from NBP API.

### GetCurrencyToday(tableCode, currencyCode, isJSON, date)

Gets Exchange rate from PLN to currencyCode from date.

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| isJSON | *System.DateTime*<br>`true` if returned string will be JSON, `false` if XML. |
| date | *System.Boolean*<br>The date. |

#### Returns

XML/JSON result from NBP API.

### GetCurrencyTodayAsync(tableCode, currencyCode, isJSON)

Gets current Exchange rate from PLN to currencyCode published today (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| currencyCode | *System.String*<br>ISO 4217 Currency Code. |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

Async XML/JSON result from NBP API.

### GetTable(tableCode, isJSON)

Gets current table of exchange rates.

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, false if XML. |

#### Returns

XML/JSON result from NBP API.

### GetTable(date, tableCode, isJSON)

Gets table of exchange rates from date.

| Name | Description |
| ---- | ----------- |
| date | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>The Date. |
| tableCode | *System.DateTime*<br>Table Code (Capital A-C). |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, false if XML. |

#### Returns

XML/JSON result from NBP API.

### GetTableAsync(tableCode, isJSON)

Gets current table of exchange rates (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

Async XML/JSON result from NBP API.

### GetTableAsync(tableCode, isJSON, date)

Gets table of exchange rates from date (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| isJSON | *System.DateTime*<br>`true` if returned string will be JSON, `false` if XML. |
| date | *System.Boolean*<br>the date. |

#### Returns

Async XML/JSON result from NBP API.

### GetTables(startDate, endDate, tableCode, isJSON)

Gets tables from startDate to endDate.

| Name | Description |
| ---- | ----------- |
| startDate | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Start date. |
| endDate | *System.DateTime*<br>End date. |
| tableCode | *System.DateTime*<br>Table Code (Capital A-C). |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

XML/JSON result from NBP API.

### GetTables(topCount, tableCode, isJSON)

Gets last topCount of tables.

| Name | Description |
| ---- | ----------- |
| topCount | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Amount of tables to return. |
| tableCode | *System.Int32*<br>Table Code (Capital A-C). |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

XML/JSON result from NBP API.

### GetTablesAsync(tableCode, startDate, endDate, isJSON)

Gets tables from startDate to endDate (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| startDate | *System.DateTime*<br>Start date. |
| endDate | *System.DateTime*<br>End date. |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

Async XML/JSON result from NBP API.

### GetTablesAsync(tableCode, topCount, isJSON)

Gets last topCount of tables (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| topCount | *System.Int32*<br>Amount of tables to return. |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

Async XML/JSON result from NBP API.

### GetTableToday(tableCode, isJSON)

Gets table of exchange rates published today.

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, false if XML. |

#### Returns

XML/JSON result from NBP API.

### GetTableTodayAsync(tableCode, isJSON)

Gets table of exchange rates published today (asynchronous).

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>Table Code (Capital A-C). |
| isJSON | *System.Boolean*<br>`true` if returned string will be JSON, `false` if XML. |

#### Returns

Async XML/JSON result from NBP API.


## TableCode

Table codes - A, B or C

### NBPCurrencyAPILib.NBPAPI.TableLetter(tableCode)

| Name | Description |
| ---- | ----------- |
| tableCode | *NBPCurrencyAPILib.NBPAPI.TableCode*<br>The table code. |

#### Returns

Table Code as a letter

*System.ArgumentException:* Incorrect table code.

### NBPCurrencyAPILib.NBPAPI.uri

http://api.nbp.pl/api/
