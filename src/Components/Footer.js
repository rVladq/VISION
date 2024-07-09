import './Footer.css'

const Footer = () => {
  const githubUrl = 'https://github.com/your-username/your-repository'; // Replace with your GitHub repository URL

  return (
    <footer className='footer'>
      <a href={'https://github.com/rVladq/VISION/tree/frontend'} target="_blank" rel="noopener noreferrer">
        <p>GitHub</p>
      </a>
    </footer>
  );
};

export default Footer;
