import { act, useEffect, useState } from 'react'
// import reactLogo from './assets/react.svg'
// import viteLogo from '/vite.svg'
import './App.css'
import axios from 'axios'
import { Header, List } from 'semantic-ui-react'

function App() {
  const [activities, setActivities] = useState([])

  useEffect(() => {
    axios.get("http://localhost:5000/api/activities")
    .then(response => {
      setActivities(response.data)
    })
  }, []) // this second argument [] is dependencies. If one of dependencies change, useEffect is called again

  return (
    <div>
      <Header as="h2" icon="users" content="Reactivities" />
      <List>  
        {activities.map((activity: any) => (
            <List.Item key={activity.id}>
              {activity.title}
            </List.Item>
          ))}
      </List>
      <ul>
        
      </ul>
    </div>
    
  )
}

export default App
