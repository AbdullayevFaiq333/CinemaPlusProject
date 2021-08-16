import React, { useEffect, Component } from "react";
import { useSelector, useDispatch } from "react-redux";
import { fetchContentNews } from "../actions";
import Slider from "react-slick";

const News = () => {
  const dispatch = useDispatch();

  const { content } = useSelector((state) => state.contentNews);

  useEffect(() => {
    dispatch(fetchContentNews());
  }, [dispatch]);

  const settings = {
    dots: true,
    infinite: false,
    speed: 500,
    slidesToShow: 4,
    slidesToScroll: 4,
    initialSlide: 0,
  };

  return (
    <div className="news-section">
     <div class="tab_header">
      <a href="#" class="active" id="news_film">CINEMAPLUS XƏBƏRLƏRİ</a>
    </div>
    <div class="indexNews">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div class="newsSection">
              <div class="newsBody">
                <div class="owl-carousel owl-theme">
                <Slider {...settings}>
                  {content.map((newsItem) => {
                    return (
                      
                        <div key={newsItem.id} class="item">
                          <div class="newsImg">
                            <a href="#">
                              <img src={`./images/${newsItem.image}`} />
                            </a>
                          </div>
                          <div class="newsDate">{newsItem.dateTime}</div>
                          <h3>
                            <a href="#">{newsItem.title}</a>
                          </h3>
                          <div class="newsDesc">{newsItem.decription}</div>
                        </div>
                      
                    );
                  })}
                  </Slider>
                </div>
                <a href="#" class="allNews">BÜTÜN XƏBƏRLƏR</a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    </div>
  );
};

export default News;
