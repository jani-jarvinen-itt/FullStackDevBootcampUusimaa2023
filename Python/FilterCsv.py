import csv

with open("Customers.csv") as csv_file:
    csv_reader = csv.reader(csv_file, delimiter=',')
    line_count = 0
    for row in csv_reader:
        if line_count == 0:
            print(f'Column names are {", ".join(row)}')
            line_count += 1
        else:
            company_name = row[1]
            if len(company_name) > 0:
                country = row[3]
                if country == "France":
                    print(f'\tCompany {row[1]} is from the country {country}.')
            line_count += 1
    print(f'Processed {line_count} lines.')

print("End.")
