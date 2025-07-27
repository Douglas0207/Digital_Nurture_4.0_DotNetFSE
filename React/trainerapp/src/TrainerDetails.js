import { useParams } from "react-router-dom";
import trainerData from "./TrainersMock"; 

function TrainerDetails() {
  const { id } = useParams();

  const trainer = trainerData.find((t) => t.id === parseInt(id));

  if (!trainer) {
    return <p>Trainer not found</p>;
  }

  return (
    <div>
      <h2>{trainer.name}</h2>
      <p>Email: {trainer.email}</p>
      <p>Phone: {trainer.phone}</p>
      <p>Technology: {trainer.technology}</p>
      <p>Skills: {trainer.skills.join(", ")}</p>
    </div>
  );
}

export default TrainerDetails;
