import { Dimmer, Loader, Segment } from "semantic-ui-react"
interface Props{
    inverted?:boolean;
    content?:string;
}
export const LoadingComponent = ({inverted=true, content = 'در حال دریافت اطلاعات...'}:Props) => {
    
    return(
          <Dimmer active={true} inverted={inverted}>
            <Loader>{content}</Loader>
          </Dimmer>
    )
}