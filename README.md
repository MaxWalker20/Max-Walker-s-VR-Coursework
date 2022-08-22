## Max Walker's VR Coursework
### What it Does 
This is a teaching tool designed to help young students learn the relationships between the pitches of two different sounds, and their harmonic relationships to eachother, specifically on the diatonic scale. Intervals between notes which are closer to low numbers have simpler ratios and are seen as more 'consonant' (eg. Perfect fifth; 3:2, Perfect octave; 2:1), as opposed to more complex fractions which are seen as more 'dischordant' (eg. Minor second; 16:15, Augmented fourth; 45:32).
 
By mapping these relationships on a sine wave, their relative complexities are given a more intuitive comparison in the form of the smoothness and relationships of the curves. This is useful both practically in the field of acoustics, and theoretically with regards to a deeper understanding of the maths involved.


https://user-images.githubusercontent.com/101332382/185896987-4eecaf61-c442-4a2e-927f-406543c0721a.mp4



https://user-images.githubusercontent.com/101332382/185896994-496d7221-f6b5-4330-874e-d42c7d248edc.mp4



https://user-images.githubusercontent.com/101332382/185896995-268f6e51-66dc-449c-a0ed-5d9ccb4670d4.mp4



https://user-images.githubusercontent.com/101332382/185896999-524bb370-4177-429d-822f-c1a4af8a223f.mp4


> These videos are not of the final product.

### How to run it

Simply run the built version using Unity. This version is not fully functional in terms of user interactability.

### Future Features
- By adding a slider from 0 to 1, a decimal fraction can be obtained. This would give a considerably more smooth continuum of the sine function instead of entering the numbers for the ratios.
- Other sound waves, such as a sawtooth, squarewave, Triangular wave etc. may be graphable. A user could also upload more complex waves such as their own voice, and compare the differences. 
- The sound of each wave could be played at the same as it's interval or sample.
- There is also potential for fourier transforms and spectrographic analysis of waveforms, which would be of interest to music technology students.
- By mapping the wave in a vector, this can be extended to three dimensions. For instance for seeing spectrographic peaks over time.
- An oscilloscope version is entirely possible by including Diophantine equations - even by maping them in 3D or by flattening the tails of such equations on the 3D map to 2D.
- 
### Known Bugs
- Due to issues with resolving static classes, the front end User Interface is currently non functional. 

### Coding Credit
- A significant portion of the `Graph.cs` and `FunctionSelector.cs` files, as well as certain Unity settings relating to the startup, have been very closely followed from the public domain blog Catlikecoding.com, run by Jasper Flick. I give full credit for those resources therein.
### Github page
This project can be found at https://github.com/MaxWalker20/Max-Walker-s-VR-Coursework