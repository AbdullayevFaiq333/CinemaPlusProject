import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import {
  fetchContentNavbar,
  fetchContentPlatinum,
  fetchContentDolbyAtmos,
  fetchLanguages,
  fetchContentService,
  fetchContentFooter,
  fetchContentSecondFooter,
  fetchContentNews,
  fetchContentFAQ,
  fetchContentCampaigns,
  fetchContentCampaignDetail,
  fetchContentMovie,
  fetchContentMovieDetail,
} from "../actions";
import { Link } from "react-router-dom";

const Header = () => {
  const dispatch = useDispatch();

  const { languages } = useSelector((state) => state.languages);
  const { content, loading } = useSelector((state) => state.contentNavbar);

  useEffect(() => {
    dispatch(fetchContentNavbar());
    dispatch(fetchLanguages());
  }, [dispatch]);

  const handleClickLanguage = (code) => {
    dispatch(fetchContentNavbar(code));
    dispatch(fetchContentPlatinum(code));
    dispatch(fetchContentDolbyAtmos(code));
    dispatch(fetchContentService(code));
    dispatch(fetchContentFooter(code));
    dispatch(fetchContentSecondFooter(code));
    dispatch(fetchContentNews(code));
    dispatch(fetchContentFAQ(code));
    dispatch(fetchContentCampaigns(code));
    dispatch(fetchContentCampaignDetail(code));
    dispatch(fetchContentMovie(code));
    dispatch(fetchContentMovieDetail(code));
  };

  return (
    <div className="navbar">
      {loading ? (
        <h1>loading</h1>
      ) : (
        <div className="container-fluid">
          <div className="row">
            <div className="col-md-5 p-0">
              <div className="nav-logo">
                <img
                  src="http://localhost:3000/images/navbar/logo.svg"
                  className="mr-auto"
                  alt=""
                />
              </div>
            </div>
            <div className="col-md-7">
              <div className="row">
                <div className="nav-right-up">
                  
                  <ul className="static_menu d-flex">
                    {content.navbarDto.map((navbarItem) => {
                      return (
                        <li key={navbarItem.id}>
                          <Link to={`${navbarItem.url}`}>
                            {" "}
                            {navbarItem.title}
                          </Link>
                        </li>
                      );
                    })}
                  </ul>
                  <ul className="languages">
                    {languages.map((language) => {
                      return (
                        <li
                          key={language.id}
                          onClick={() => handleClickLanguage(language.code)}
                        >
                          {language.code}
                        </li>
                      );
                    })}
                    <img src="http://localhost:3000/images/navbar/ios.svg" />
                    <img src="http://localhost:3000/images/navbar/android.svg" />
                  </ul>
                </div>
                <div className="nav-right-down">
                  <ul className="d-flex">
                    {content.secondNavbarDto.map((secondNavbarItem) => {
                      return (
                        <li key={secondNavbarItem.id}>
                          <Link to={`${secondNavbarItem.url}`}>
                            {" "}
                            {secondNavbarItem.title}
                          </Link>
                        </li>
                      );
                    })}
                    <div className="phone">
                      <i class="fas fa-phone-alt"></i>+99412 499 89 88
                    </div>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </div>
      )}
      
    </div>
  );
};

export default Header;
