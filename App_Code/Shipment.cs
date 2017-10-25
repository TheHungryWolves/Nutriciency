using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Shipment
{
    private String UPC;
    private String departureDate;
    private int quantity;
    private double weight;
    private String lastUpdatedBy;
    private String lastUpdated;
    private int distributorID;

    public Shipment()
    {
        setUPC("");
        setDepartureDate("");
        setQuantity(0);
        setWeight(0.0);
        setLastUpdatedBy("");
        setLastUpdated("");
        setDistributorID(0);
    }

    public Shipment(String upc, String departureDate, int quantity, double weight,
        String lastUpdatedBy, String lastUpdated, int distributorID)
    {
        setUPC(upc);
        setDepartureDate(departureDate);
        setQuantity(quantity);
        setWeight(weight);
        setLastUpdatedBy(lastUpdatedBy);
        setLastUpdated(lastUpdated);
        setDistributorID(distributorID);
    }

    public void setUPC(string upc)
    {
        this.UPC = upc;
    }

    public void setDepartureDate(String depDate)
    {
        this.departureDate = depDate;
    }

    public void setQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    public void setWeight(double weight)
    {
        this.weight = weight;
    }

    public void setLastUpdatedBy(string lastUpdatedBy)
    {
        this.lastUpdatedBy = lastUpdatedBy;
    }

    public void setLastUpdated(string lastUpdated)
    {
        this.lastUpdated = lastUpdated;
    }

    public void setDistributorID(int distributorID)
    {
        this.distributorID = distributorID;
    }

    public String getUPC()
    {
        return this.UPC;
    }

    public String getDepartureDate()
    {
        return this.departureDate;
    }

    public int getQuantity()
    {
        return this.quantity;
    }

    public double getWeight()
    {
        return this.weight;
    }

    public String getLastUpdatedBy()
    {
        return this.lastUpdatedBy;
    }

    public String getLastUpdated()
    {
        return this.lastUpdated;
    }

    public int getDistributorID()
    {
        return this.distributorID;
    }
}