# Simple Calculator

```csharp
SimpleCalculatorController simpleCalculatorController = client.SimpleCalculatorController;
```

## Class Name

`SimpleCalculatorController`


# Calculate

Calculates the expression using the specified operation.

```csharp
CalculateAsync(
    double x,
    double y,
    Models.OperationTypeEnum operation)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `x` | `double` | Query, Required | The LHS value. |
| `y` | `double` | Query, Required | The RHS value. |
| `operation` | [`Models.OperationTypeEnum`](../../doc/models/operation-type-enum.md) | Template, Required | The operator to apply on the variables. |

## Response Type

`Task<double>`

## Example Usage

```csharp
double x = 222.14;
double y = 165.14;
OperationTypeEnum operation = OperationTypeEnum.ADD;

try
{
    double? result = await simpleCalculatorController.CalculateAsync(x, y, operation);
}
catch (ApiException e){};
```

