from fastapi import FastAPI
import cv2
import numpy as np
import io
from fastapi.responses import StreamingResponse
from fastapi.middleware.cors import CORSMiddleware

app = FastAPI()
app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],  # Allow all origins
    allow_credentials=True,
    allow_methods=["*"],  # Allow all methods (GET, POST, etc.)
    allow_headers=["*"],  # Allow all headers
)

def capture_frame():
    cap = cv2.VideoCapture(0)  # Open webcam
    ret, frame = cap.read()
    cap.release()  # Release webcam

    if not ret:
        return None

    _, buffer = cv2.imencode('.jpg', frame)  # Convert frame to JPEG
    return buffer.tobytes()

@app.get("/capture")
async def capture():
    frame = capture_frame()
    if frame is None:
        return {"error": "Failed to capture image"}

    return StreamingResponse(io.BytesIO(frame), media_type="image/jpeg")  # Return image as response

if __name__ == "__main__":
    import uvicorn
    uvicorn.run(app, host="127.0.0.1", port=8000)
