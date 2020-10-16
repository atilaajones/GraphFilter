# GraphFilter
<a href="https://doi.org/10.5281/zenodo.4047104"><img src="https://zenodo.org/badge/DOI/10.5281/zenodo.4047104.svg" alt="DOI"></a>

## Description
The software proposes to filter a list of graphs (from Graph Theory) according to properties established by the user, allowing the visualization of the filtered graphs. It then provides assistance to graph theory researchers (and spectral graph theory) to establish or refute conjectures quickly and simply. The web page of the software is sistemas.jf.ifsudestemg.edu.br/graphfilter

## Installation
It's done by executing the GraphFilter.msi file, the program is supported by any Windows (64bit)

## Usage
The use of the program does not require knowledge of the user in any programming language, as it has an intuitive interface and visual graph export functionality. 
The list of graphs given as input to the program is a text file containing graphs encoded in the [Graph6](https://users.cecs.anu.edu.au/~bdm/data/formats.html) format.

### List of Graph in input file
Many classes of graphs are already encoded in this file format and available in different sources, such as:
- **[House of Graphs](https://hog.grinvin.org/MetaDirectory.action)**: web page that concentrates several works on graph generation in classes. In the menu *Graph meta-directory* there are several lists, separated by classes of graphs, available for download
- **[Graphs by Brendan McKay](http://users.cecs.anu.edu.au/~bdm/data/graphs.html)**: web page that makes available for download a list of graphs already generated by *Nauty adn Traces*.
- **[Nauty and Traces](http://pallini.di.uniroma1.it/)**: program that has a package that allows the generation of small graphs including some simple restrictions

### Customizable conditions for graph filtering
To process the list of graphs, the software checks which Boolean conditions were checked and which were the invariants defined by the equations (or inequalities) created by the user.  Below we list the invariants already implemented. 

Boolean Invariants: 
- regular
- k-regular
- Largest A-eigenvalue is integer (or Q, or L);
- There is integer A-eigenvaluer  (or Q, or L);
- A-integral (or Q, or L);
- Hamiltonian
- Planar
- Acyclic
- Connected

Numeric Invariants: 
- Largest A-eigenvalue (or Q, or L);
- Second largest A-eigenvalue (or Q, or L);
- Laplacian Energy;
- Algebraic Connectivity
- Maximum, Minimum and Average Degree;
- Number of vertices or edges;
- Clique number
- Independence Number
- Matching Number
- Girth
- Chromatic Number
- Diameter
- Edge Connectivity
- Number of Spanning Trees

Equations (or inequalities) are entered by the user and can involve one or more numeric invariants.
more details about using the software can be found in the [user guide](http://sistemas.jf.ifsudestemg.edu.br/graphfilter/user-guide).

## Authors

**[Átila Arueira Jones](lattes.cnpq.br/0512886691975427)**, Professor from Instituto Federal Sudeste de Minas Gerais – Juiz de Fora, atila.jones@ifsudestemg.edu.br

**[Denilson Paula de Oliveira Ribeiro](lattes.cnpq.br/3015094474391866)**, Graduating from Instituto Federal Sudeste de Minas Gerais – Juiz de Fora, denilsonrib9@gmail.com

**[Lavínia Beghini de Castro](lattes.cnpq.br/4628343748028263)**, Graduating from Instituto Federal Sudeste de Minas Gerais – Juiz de Fora, lavinia.beghini@gmail.com
