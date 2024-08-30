import React, { useState } from 'react';
import { motion, AnimatePresence } from 'framer-motion';
import Header from '../components/Header/Header';
import Flag from '../components/Flag/Flag';
import Tabs from '../components/Tabs/Tabs';
import Description from '../components/Description/Description';
import Card from '../components/CardDepartament/CardDepartament';
import ArrowButton from '../components/ButtonsDepartament/ButtonsDepartament';

const images = [
  { src: '/image1.jpg', alt: 'Castle of Gloriet' },
  { src: 'image1.jpg', alt: 'Interior' },
  { src: '/image2.jpg', alt: 'Courtyard' },
];

const Chuquisaca = () => {
  const [currentIndex, setCurrentIndex] = useState(0);

  const handlePrev = () => {
    setCurrentIndex((prevIndex) => (prevIndex === 0 ? images.length - 1 : prevIndex - 1));
  };

  const handleNext = () => {
    setCurrentIndex((prevIndex) => (prevIndex === images.length - 1 ? 0 : prevIndex + 1));
  };

  const reorderedImages = [
    images[(currentIndex + 0) % images.length],
    images[(currentIndex + 1) % images.length],
    images[(currentIndex + 2) % images.length],
  ];

  return (
    <div className="bg-[#FFF8E1] font-sans min-h-screen flex flex-col">
      <Header onLanguageChange={() => {}} />
      <Flag />
      <main className="flex-1 flex flex-col p-4 md:p-6 max-w-6xl mx-auto w-full">
        <Tabs />
        <div className="flex flex-col lg:flex-row justify-between items-start gap-6 lg:gap-12 min-h-[calc(100vh-300px)]">
          <Description className="w-full lg:w-1/4 mb-6 lg:mb-0" />
          <div className="w-full lg:w-3/4 flex flex-col items-center">
            {/* Navigation buttons for mobile and tablet */}
            <div className="flex justify-center space-x-4 mb-4 lg:hidden w-full">
              <ArrowButton direction="left" onClick={handlePrev} />
              <ArrowButton direction="right" onClick={handleNext} />
            </div>
            <div className="flex flex-wrap lg:flex-nowrap justify-center lg:justify-between items-end w-full gap-4 lg:gap-8">
              <AnimatePresence initial={false}>
                {reorderedImages.map((image, index) => (
                  <motion.div
                    key={image.src}
                    layout
                    initial={{ scale: 0.8, opacity: 0 }}
                    animate={{ 
                      scale: 1, 
                      opacity: 1,
                      y: index === 1 ? 20 : 0 // Ajusta este valor según necesites
                    }}
                    exit={{ scale: 0.8, opacity: 0 }}
                    transition={{ duration: 0.3 }}
                    className="flex-shrink-0"
                  >
                    <Card
                      image={image.src}
                      alt={image.alt}
                      size={index === 0 ? 'large' : 'small'}
                    />
                  </motion.div>
                ))}
              </AnimatePresence>
            </div>
            {/* Navigation buttons for desktop */}
            <div className="hidden lg:flex justify-center space-x-4 mt-4 w-full">
              <ArrowButton direction="left" onClick={handlePrev} />
              <ArrowButton direction="right" onClick={handleNext} />
            </div>
          </div>
        </div>
      </main>
    </div>
  );
};

export default Chuquisaca;