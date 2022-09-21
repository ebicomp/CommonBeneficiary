import { useContext , createContext} from "react";

import RelationTypeStore from "./relationTypeStore";

interface Store{
    relationTypeStore:RelationTypeStore
}
export const store:Store={
    relationTypeStore : new RelationTypeStore()
}
export const StoreContext = createContext(store)

export function useStore(){
    return useContext(StoreContext);
}