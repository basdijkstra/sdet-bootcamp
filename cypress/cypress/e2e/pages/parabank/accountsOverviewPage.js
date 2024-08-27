import SideMenu from "./components/sideMenu";

class AccountsOverviewPage {

    constructor() {
        this.sideMenu = new SideMenu()
    }

    selectRequestLoan() {
        this.sideMenu.selectRequestLoan()
    }
}

export default AccountsOverviewPage