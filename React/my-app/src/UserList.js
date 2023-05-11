import { useState } from 'react';

function UserList() {
    const [userList, setUserList] = useState("");

    console.log("Starting to fetch user data...");
    fetch('https://jsonplaceholder.typicode.com/users')
        .then(response => response.json())
        .then(json => {
            console.log("Fetch of user data complete.");
            console.log(json);

            // loop through the users
            let userNames = "";
            for (let index = 0; index < json.length; index++) {
                const userData = json[index];
                userNames += userData.name + "\r\n";
            }

            // set the React component state -> causes screen to update
            setUserList(userNames);
        });

    return <div>
        <h1>This is the User List component!</h1>
        <pre>{userList}</pre>
    </div>
}

export default UserList;
