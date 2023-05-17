import { useState } from 'react';

function NorthwindCustomerList() {
    const [customerList, setCustomerList] = useState("");

    // const backendForAspNetCSharp = "http://localhost:5214/api/customers";
    const backendForPython = "http://localhost:5000/api/customers";

    console.log("Starting to fetch customer data...");
    fetch(backendForPython)
        .then(response => response.json())
        .then(json => {
            console.log("Fetch of customer data complete.");
            console.log(json);

            // loop through the customers
            let customerNames = "";
            for (let index = 0; index < json.length; index++) {
                const customerData = json[index];
                customerNames += customerData.companyName + "\r\n";
            }

            // set the React component state -> causes screen to update
            setCustomerList(customerNames);
        });

    return <div>
        <h1>This is the Northwind Customer List component!</h1>
        <pre>{customerList}</pre>
    </div>
}

export default NorthwindCustomerList;
