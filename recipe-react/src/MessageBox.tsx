

import { useEffect } from "react";
import { Toast } from 'bootstrap';

interface Props {
    message: string;
    msgClassName: string;
    onClose: () => void
}

export function MessageBox({ message, msgClassName, onClose }: Props) {

    useEffect(() => {
        const toastElement = document.getElementById('liveToast');
        if (toastElement) {
            const toast = new Toast(toastElement);
            toast.show();
        }
    }, [])

    const handleClose = () => {
        onClose();
    }

    return (
        <div aria-live="polite" aria-atomic="true" className="d-flex justify-content-center align-items-center w-100">
            <div id="liveToast"
                className="toast "
                role="alert" aria-live="assertive" aria-atomic="true" data-bs-autohide="false">
                <div className="d-flex m-2 justify-content-between align-items-center">
                    <div className={`toast-body ${msgClassName}`}>
                        {message}
                    </div>
                    <button onClick={handleClose} type="button" className="btn-close me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                </div>
            </div>
        </div>
    )
}