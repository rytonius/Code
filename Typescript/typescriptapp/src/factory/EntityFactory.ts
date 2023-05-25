import {Entity} from '../models/Entity'

export function CreatePlayer(name: string = "Billy", hp: number = 100) {
    return new Entity(name, hp);

  }