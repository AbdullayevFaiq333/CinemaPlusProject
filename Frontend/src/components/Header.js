import React,{useEffect} from 'react';
import { useSelector,useDispatch } from 'react-redux';
import { fetchContent } from '../actions';


const Header = () => {
    const dispatch = useDispatch();

    const {content,loading} = useSelector(state => state.content);

    useEffect(() => {
        dispatch(fetchContent());
    }, [dispatch])


    return (
        <div>
            {loading ? <h1>loading</h1> : (
                <div className="container-fluid">
                <div className="row">
                    <div className="col-md-5 px-0">
                        <div className="nav-logo">
                            <img src="./images/logo.svg" className="mr-auto"/>
                        </div>
                       
                    </div>
                    <div className="col-md-7">
                         <div className="row" >
                             <div className="nav-right-up">
                             <ul className="d-flex" >
                                 {content.navbarDto.map(navbarItem => {
                                     return (
                                         <li>{navbarItem.Title}</li>
                                     )
                                 })}

                             </ul>
                             <ul>
                                 <li>az</li>
                                 <li>ru</li>
                                 <li>en</li>
                             </ul>
                             
                             </div>
                             <div className="nav-right-down">
                             <ul className="d-flex" >
                                <li>asd</li>
                                <li>das</li>
                                <li>sad</li>
                                <li>sad</li>
                             </ul>
                             </div>
                         </div>
                    </div>

                </div>

            </div>
            )}
            
        </div>
    )
}

export default Header
