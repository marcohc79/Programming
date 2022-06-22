# Crear estructura
import queue
cola = queue.Queue()

cola.put(5)
cola.put([2,3,4])
print(cola.get())
print(cola.get())
print(cola.empty())
