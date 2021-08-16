import React, { useState, useEffect, useRef } from "react";
import { useSelector,useDispatch } from "react-redux";
import { fetchContentFAQ } from '../actions';

export default function Accordion() {

  const dispatch = useDispatch();
    
    
  const { content } = useSelector((state) => state.contentFAQ);

  useEffect(() => {
      dispatch(fetchContentFAQ());
      console.log(refHeight);
  }, [dispatch])

  const [toggle, setToggle] = useState(false);
  const [toggleClass, setToggleClass] = useState({});
  const [heightEl, setHeightEl] = useState(0);

  const refHeight = useRef();
  const refButton = useRef();

  useEffect(() => {
    console.log(refHeight);
    if(refHeight.current !== undefined){
      setHeightEl(`${refHeight.current.scrollHeight}px`);
    }
  }, [content]);

  const toggleState = (id) => {
    setToggle(!toggle);
    setToggleClass({...toggleClass, id: id})
  };

  console.log(toggle);
  return (<>{content.map((FAQItem) => {
    return (
      <div key={FAQItem.id} className="accordion ">
      <button onClick={() => toggleState(FAQItem.id)} className={`accordion-visible ${FAQItem.id}`} ref={refButton}>
        <span>{FAQItem.title}</span>
        <img className={toggle && "active"} src="images/FAQ/chevron.svg" />
      </button>

      <div
        className={`accordion-toggle ${toggle && toggleClass.id === FAQItem.id ? `animated` : " "}`}
        style={{ height: toggle && toggleClass.id === FAQItem.id ? `${heightEl}` : "0px" }}
        ref={refHeight}
      >
        <p aria-hidden={toggle && toggleClass.id === FAQItem.id ? "true" : "false"}>
        {FAQItem.description}
        </p>
      </div>
    </div>
   
    );
  })}
    
    </>
  );
}
