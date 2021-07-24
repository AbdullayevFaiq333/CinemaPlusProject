import React,{useEffect} from 'react';
import { useSelector,useDispatch } from 'react-redux';
import { fetchContentNavbar,fetchLanguages } from '../actions';


const Header = () => {
    const dispatch = useDispatch();

    const {languages} = useSelector(state => state.languages);
    const {contentNavbar,loading} = useSelector(state => state.contentNavbar);

    useEffect(() => {
        dispatch(fetchContentNavbar());
        dispatch(fetchLanguages());
    }, [dispatch])

    const handleClickLanguage = (code) => {
        dispatch(fetchContentNavbar(code));
    }

    return (
        <div className="navbar">
            {loading ? <h1>loading</h1> : (
                <div className="container-fluid">
                <div className="row">
                    <div className="col-md-5 px-0">
                        <div className="nav-logo">
                            <img src="./images/navbar/logo.svg" className="mr-auto" alt="" />
                        </div>
                       
                    </div>
                    <div className="col-md-7">
                         <div className="row" >
                             <div className="nav-right-up">
                             <ul className="d-flex" >
                                 {contentNavbar.navbarDto.map(navbarItem => {
                                     return (
                                         <li key={navbarItem.id}>{navbarItem.title}</li>
                                     )
                                 })}

                             </ul>
                             <ul className="languages">
                                 {languages.map(language => {
                                     return (
                                        <li key={language.id} onClick={() => handleClickLanguage(language.code)}>{language.code}</li>
                                     )
                                 })}
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
