import { Dimmer, Loader, Segment } from "semantic-ui-react"
interface Props{
    inverted?:boolean;
    content?:string;
}
export const LoadingComponent = ({inverted=true, content = 'در حال دریافت اطلاعات...'}:Props) => {
    
    return(
        <div>
        <Segment>
          <Dimmer active={true} inverted={inverted}>
            <Loader indeterminate>{content}</Loader>
          </Dimmer>
        </Segment>
      </div>
    )
    
}