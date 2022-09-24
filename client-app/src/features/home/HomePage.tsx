import { handleRef } from "@fluentui/react-component-ref";
import { observer } from "mobx-react-lite";
import { toast } from "react-toastify";
import { Button } from "semantic-ui-react";

const HomePage = () => {
    const handleClick = ()=>{
        toast.error('خطای ناشناخته');
    }
    return (
        <>
            <h1>Home Page</h1>
            <Button onClick={handleClick}>Test Toast Error</Button>
        </>
    )
}
export default observer(HomePage);