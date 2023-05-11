import { useState } from 'react';

function UserList()
{
    const [userList, setUserList] = useState([]);

    return <div>
        <h1>This is the User List component!</h1>
        <pre>{userList}</pre>
    </div>
}

export default UserList;
