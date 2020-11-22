# TimeZoneConverter
A converter that converts from IANA to Windows Time zones and vice versa

I have created a small UI as a Windows Form for the users to convert from system to another. 
Basic idea is that a converter/populator is connected with the database and datascraper.
For the first time the populator fetches data from the website and inserts it into the database for future conversions.
In the test project I've added the data validation checks whether conversion values are correct from both systems, as well as the test to see if datapopulator really populates
all the necessary data.
