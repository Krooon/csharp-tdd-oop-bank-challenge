```
As a customer,
So I can safely store use my money,
I want to create a current account.

As a customer,
So I can save for a rainy day,
I want to create a savings account.

As a customer,
So I can keep a record of my finances,
I want to generate bank statements with transaction dates, amounts, and balance at the time of transaction.

As a customer,
So I can use my account,
I want to deposit and withdraw funds.
```


```
As a customer,
So I can safely store use my money,
I want to create a current account.
```

| Classes         | Methods/Properties                                 | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------
|CurrentAccount.cs|Add & Subract (decimal a, decimal b)				   |a + b & a - c					 |the result of the formual with a and b
|				  |													   |								 |					




```
As a customer,
So I can save for a rainy day,
I want to create a savings account.
```


| Classes         | Methods/Properties                                 | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------
|SavingsAccount.cs|Add & Subract (decimal a, decimal b)				   |a + b & a - c					 |the result of the formual with a and b	
|				  |													   |								 |					



```
As a customer,
So I can keep a record of my finances,
I want to generate bank statements with transaction dates, amounts, and balance at the time of transaction.
```

| Classes			| Methods/Properties                                   | Scenario							| Outputs          |
|-----------------	|---------------------------  -------------------------|---------------------------------	|------------------
|BankTransactions.cs|Stringbuilder.Append								   |Transaction A + Transaction B +	etc.|Receipt of transactions	
|					|													   |									|					
				


```
As a customer,
So I can use my account,
I want to deposit and withdraw funds.
```
| Classes				| Methods/Properties								   | Scenario                        | Outputs          |
|-----------------		|----------------------------------------------------  |---------------------------------|------------------
|ChangeBankBalance.cs	|Add & Subract (decimal a, decimal b)				   |a + b & a - c					 |	
|						|													   |								 |					
|						|													   |								 |					

