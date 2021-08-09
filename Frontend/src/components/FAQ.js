import React, { useState, useEffect, useRef } from "react";
import { useSelector,useDispatch } from "react-redux";
import { fetchContentFAQ } from '../actions';

export default function Accordion() {

  const dispatch = useDispatch();
    
    
  const { content } = useSelector((state) => state.contentFAQ);

  useEffect(() => {
      dispatch(fetchContentFAQ());
      
  }, [dispatch])

  const [toggle, setToggle] = useState(false);
  const [heightEl, setHeightEl] = useState();

  const refHeight = useRef();

  useEffect(() => {
    console.log(refHeight);
    setHeightEl(`${refHeight.current.scrollHeight}px`);
  }, []);

  const toggleState = () => {
    setToggle(!toggle);
  };

  console.log(toggle);
  return (<>{content.map((FAQItem) => {
    return (
      <div key={FAQItem.id} className="accordion">
      <button onClick={toggleState} className="accordion-visible">
        <span>{FAQItem.title}</span>
        <img className={toggle && "active"} src="images/FAQ/chevron.svg" />
      </button>

      <div
        className={toggle ? "accordion-toggle animated" : "accordion-toggle"}
        style={{ height: toggle ? `${heightEl}` : "0px" }}
        ref={refHeight}
      >
        <p aria-hidden={toggle ? "true" : "false"}>
        {FAQItem.description}
        </p>
      </div>
    </div>
   
    );
  })}
    <div className="accordion">
      <button onClick={toggleState} className="accordion-visible">
        <span>Lorem ipsum dolor sit amet.</span>
        <img className={toggle && "active"} src="images/FAQ/chevron.svg" />
      </button>

      <div
        className={toggle ? "accordion-toggle animated" : "accordion-toggle"}
        style={{ height: toggle ? `${heightEl}` : "0px" }}
        ref={refHeight}
      >
        <p aria-hidden={toggle ? "true" : "false"}>
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Inventore,
          suscipit quae maiores sunt ducimus est dolorem perspiciatis earum
          corporis unde, dicta quibusdam aut placeat dignissimos distinctio vel
          quo eligendi ipsam.
        </p>
      </div>
    </div>
    </>
  );
}
