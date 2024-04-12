﻿namespace ConvenienceStore.Features.Kardexs.ViewModels;

public class CreateKardexVM
{
    public Guid ProductId { get; private set; }
    public DateTime Date { get; private set; }
    public bool IsEntry { get; private set; }
    public int AbsoluteQuantity { get; private set; }
    public decimal AbsoluteUnitValue { get; private set; }
    public decimal AbsoluteTotalValue { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitValue { get; private set; }
    public decimal TotalValue { get; private set; }
    public string History { get; private set; }
    public int AvailableStock { get; private set; }
    public decimal AverageCost { get; private set; }

    public CreateKardexVM()
    {
    }

    public CreateKardexVM(Guid productId, bool isEntry, int absoluteQuantity, decimal absoluteUnitValue, string history)
    {
        ProductId = productId;
        Date = DateTime.Now;
        IsEntry = isEntry;
        AbsoluteQuantity = absoluteQuantity;
        AbsoluteUnitValue = absoluteUnitValue;
        History = history;
    }
}
