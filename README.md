## Akka.Net Actor Model PoC implementation for HSM virtualization system

This application implemented as a basic proof of concept Akka.Net actor-model system for high volume HSM encryption operations in a dynamic environment where cryptographic operation keys and HSM's used in the system can be changed during cryptographic operations. Developed with .Net 6.0 Winforms Application.

Actor system is a high performing multi threaded message passing system for distributed code execution. Akka.net is a proven implementation of actor system which can be used in .Net applications.

Akka.Net provides:
-   Multi-threaded behavior without the use of low-level concurrency constructs like atomics or locks. You do not even need to think about memory visibility issues.
-   Transparent remote communication between systems and their components. You do not need to write or maintain difficult networking code.
-   A clustered, high-availability architecture that is elastic, scales in or out, on demand.

You can find detailed information about Akka.Net at [here](https://getakka.net/articles/intro/what-is-akka.html "here")

### Features of the application
- HSM's virtualized as an actor to handle messages for a high performing manner.(HSM functions not implemented. Uses software encrpytion for PoC purpose).
- Can add/remove HSM's and add/remove keys to HSM's before or while executing cryptographic operations.(All HSM's are expected to use the same slot and the same cryptographic keys).
- Command dispatcher logic and Round Robin algorithm used to direct cryptographic operation messages to specific HSM actor available for the next encryption operation(all HSM actors have their own message queue and handle them according to FIFO).
- HSM statistics are displayed realtime.
- Batch encryption operation can be performed by the system and real-time statistics and performance can be monitored.
- Also includes a PKCS11 encryption example(used PKCS11Interop library) to encrypt and decrypt data using an AES crytographic key stored in a HSM.

 ### What Can Be Impreved
 - Using a Redis like distributed cache system to store and read HSM statistics
 - Developing a seperate service(restfull or gRPC) to handle cryptographic operations
 - Implementing request/response pattern to handle encryption request synchronously to be used in other applications
 - Integrating PKCS11Interop library to use HSM functions 
 - Anything you like
