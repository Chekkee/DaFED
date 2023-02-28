# Simple challenge made for DaFED conference

Chalengers should try solve following issues in this test API:
- Getting of "Good" candidates takes long, fix this bug
- Retrieving "Decent" candidates returns bad results, fix this bug
- Retrieving "Bad" candidates works well, do not change anything there
- Retrieving candidates younger then certain age acctually returns candidates older then proposed age, fix this bug
- Inserting new candidate is not working as it should
    - First name should be required field, with length between 3 and 20 characters
    - Last name should be required field, with length between 3 and 20 characters
    - Age should be required field, with values between 1 and 100
    - Quality can take only valid values - "Good", "Decent" or "Bad"
    - Inserting always returns error, even when the specified requirements have been met
