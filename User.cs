using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class User
{
    private String email;
    private String firstName;
    private String lastName;
    private String middleName;
    private String dateOfBirth;
    private String password;
    private String accountType;
    private String policyGroup;
    private String accountExpiration;
    private String lastUpdatedBy;
    private String lastUpdated;
    private int isDeleted;
    private int approved;
    private int foodBankID;
    public static String connectionString = "";

    public User()
    {
        setEmail("");
        setFirstName("");
        setLastName("");
        setMiddleName("");
        setDateOfBirth("");
        setPassword("");
        setAccountType("");
        setPolicyGroup("");
        setAccountExpiration("");
        setIsDeleted(0);
        setApproved(0);
        setFoodBankID(0);
        setLastUpdatedBy("Jorgensen");
        setLastUpdated("");
    }

    public User(String email, String firstName, String middleName, String lastName, 
        String password, String dateOfBirth, String accountType, String policyGroup, 
        String accountExpiration, String lastUpdatedBy, String lastUpdated, int isDeleted, 
        int approved, int foodBankID)
    {
        setEmail(email);
        setFirstName(firstName);
        setLastName(lastName);
        setMiddleName(middleName);
        setDateOfBirth(dateOfBirth);
        setPassword(password);
        setAccountType(accountType);
        setPolicyGroup(policyGroup);
        setAccountExpiration(accountExpiration);
        setIsDeleted(isDeleted);
        setApproved(approved);
        setFoodBankID(foodBankID);
        setLastUpdatedBy(lastUpdatedBy);
        setLastUpdated(lastUpdated);
    }

    public void setEmail(string email)
    {
        this.email = email;
    }

    public void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public void setMiddleName(string middleName)
    {
        this.middleName = middleName;
    }

    public void setLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public void setPassword(string password)
    {
        this.password = password;
    }

    public void setDateOfBirth(string dob)
    {
        this.dateOfBirth = dob;
    }

    public void setAccountType(string accountType)
    {
        this.accountType = accountType;
    }

    public void setPolicyGroup(string policyGroup)
    {
        this.policyGroup = policyGroup;
    }

    public void setAccountExpiration(string accountExpiration)
    {
        this.accountExpiration = accountExpiration;
    }

    public void setLastUpdatedBy(string lastUpdatedBy)
    {
        this.lastUpdatedBy = lastUpdatedBy;
    }

    public void setLastUpdated(string lastUpdated)
    {
        this.lastUpdated = lastUpdated;
    }

    public void setIsDeleted(int isDeleted)
    {
        this.isDeleted= isDeleted;
    }

    public void setApproved(int approved)
    {
        this.approved = approved;
    }

    public void setFoodBankID(int foodBankID)
    {
        this.foodBankID = foodBankID;
    }

    public String getEmail()
    {
        return this.email;
    }

    public String getFirstName()
    {
        return this.firstName;
    }

    public String getLastName()
    {
        return this.lastName;
    }

    public String getMiddleName()
    {
        return this.middleName;
    }

    public String getPassword()
    {
        return this.password;
    }

    public String getDateOfBirth()
    {
        return this.dateOfBirth;
    }

    public String getAccountType()
    {
        return this.accountType;
    }

    public String getPolicyGroup()
    {
        return this.policyGroup;
    }

    public String getAccountExpiration()
    {
        return this.accountExpiration;
    }

    public String getLastUpdatedBy()
    {
        return this.lastUpdatedBy;
    }

    public String getLastUpdated()
    {
        return this.lastUpdated;
    }

    public int getIsDeleted()
    {
        return this.isDeleted;
    }

    public int getApproved()
    {
        return this.approved;
    }

    public int getFoodBankID()
    {
        return this.foodBankID;
    }
}