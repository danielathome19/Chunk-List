[![NuGet](https://img.shields.io/nuget/v/Chunk-List.svg)](https://www.nuget.org/packages/ChunkList/)
[![CI/CT/CD](https://github.com/danielathome19/Chunk-List/actions/workflows/nuget_push.yml/badge.svg)](https://github.com/danielathome19/Chunk-List/actions/workflows/nuget_push.yml)
[![License](https://img.shields.io/github/license/danielathome19/Chunk-List.svg)](https://github.com/danielathome19/Chunk-List/blob/master/LICENSE.md)
[![DOI](https://zenodo.org/badge/DOI/10.48550/arxiv.2101.00172.svg)](https://doi.org/10.48550/arxiv.2101.00172)

# About
A Chunk List is a new, concurrent, chunk-based data structure that is easily modifiable and allows for fast runtime operations.

To find out more, check out the provided research paper:
  * /Chunk List/Presentation/"Chunk List.pdf" (DOI: [10.48550/arxiv.2101.00172](https://doi.org/10.48550/arxiv.2101.00172))

# Usage
The __Presentation__ folder (i.e., the research paper) contains a full presentation and research paper in PDF format, containing the following information:
  * What is a chunk list?
  * Where is a chunk list used?
  * Implementation details (construction, basic methods)
  * Complexity Analysis (Big-O)
  * Unit Testing
  * Integration

Program files are kept within the _master_ branch.

A full implementation of the class is kept within the __ChunkList.cs__ file in the namespace __ChunkList__, to be included within the program.

The __Unit Test/UnitTest.cs__ file contains a benchmark test for comparison between an ArrayList (List<T>) and Chunk List.

# Bugs/Features
Bugs are tracked using the GitHub Issue Tracker.

Please use the issue tracker for the following purpose:
  * To raise a bug request; do include specific details and label it appropriately.
  * To suggest any improvements in existing features.
  * To suggest new features or structures or applications.

# License
The code is licensed under Apache License 2.0.

# Citation
If you use this code for your research, please cite this project:
```
@software{Szelogowski_Chunk-List_2017,
 author = {Szelogowski, Daniel},
 doi = {10.48550/arxiv.2101.00172},
 month = {May},
 title = {{Chunk-List}},
 license = {Apache-2.0},
 url = {https://github.com/danielathome19/Chunk-List},
 version = {1.0.0},
 year = {2017}
}
```
