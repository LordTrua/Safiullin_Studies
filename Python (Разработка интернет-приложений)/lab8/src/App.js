import { BrowserRouter, Route, Switch } from "react-router-dom";
import HomePage from './pages/HomePage.js'
import ListPage from "./pages/ListPage.js";
import ObjectPage from "./pages/ObjectPage.js";

function App() {
  return (
      <BrowserRouter basename="/" >
          <Switch>
            <Route exact path="/" component={HomePage}></Route>
            <Route exact path="/GameTypes/" component={ListPage}></Route>
            <Route exact path="/GameTypes/object" component={ObjectPage}></Route>
          </Switch>
      </BrowserRouter>
  );
}

export default App;