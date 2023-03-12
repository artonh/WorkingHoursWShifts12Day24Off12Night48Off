# Working 12h during the Day, 24h Off, 12h Night and 48h Off
This algorithm determines the working intervals for a given period based on a formula that takes into account the hours of work and rest. The formula stipulates that an individual should work for 12 hours during the day, followed by a period of 24 hours of rest. Similarly, after working for 12 hours at night, there should be a rest period of 48 hours. By checking these intervals, the algorithm can ensure that the individual is not overworked and has sufficient time for rest and recovery before the next work cycle

### Usage
create the object:
var wHours = new WorkingHours(startDate);

### Examples

## Example 1
WorkingType result = wHours.GetWorkingType(dateToCheck);

## Example 2
WorkingType result = wHours.GetWorkingType(startDate, dateToCheck);


## How It works
Based on first date provided, as dayShift, it will check the second one and retrieve one of WorkingType (Day, Night, Rest).