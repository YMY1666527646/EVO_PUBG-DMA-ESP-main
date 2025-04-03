namespace pubg_dma_esp.PUBG
{
    internal static class Offsets
    {
        public readonly struct Util
        {
            public const bool OffsetDebug = false;
            public const bool CameraDebug = false;
            public const bool NamesDebug = false;
            public const bool PositionDebug = false;
        }

        public readonly struct DecryptFNameIndex // DecryptCIndex
        {
            public const uint Offset = 0x0018; // UObject - Name (ObjectID)

            public const uint NameIndexXor1 = 0xA245838;
            public const int NameIndexOne = 0x7; // ror (ShiftValue)
            public const int NameIndexTwo = 0x10; // shr/shl (?)
            public const uint NameIndexXor2 = 0x5618BE1D;
            public const bool NameIsROR = true;
        }

        public readonly struct Xenuine
        {
            public const uint Decrypt = 0x0E87D228;
        }

        public readonly struct GName
        {
            public const uint Base = 0x103AC9A8;
            public const bool OffsetBase = false;
            public const uint ElementsPerChunk = 0x4058;
        }

        public readonly struct GWorld
        {
            public const uint Base = 0x10146F38;
            // struct UWorld : UObject
            public const uint CurrentLevel = 0x0180; // struct ULevel* CurrentLevel;
            public const uint GameInstance = 0x0368; // padding[0x8] just below CurrentLevel
        }

        public readonly struct CurrentLevel
        {
            // struct ULevel : UObject
            public const uint Actors = 0x0070; // inside of padding with a minimum size of 0x8
        }

        public readonly struct GameInstance
        {
            public const uint LocalPlayers = 0x00E0; // unsure
        }

        public readonly struct Player
        {
            public const uint Controller = 0x30; // unsure
        }

        public readonly struct PlayerController
        {
            // struct APlayerController : AController
            public const uint AcknowledgedPawn = 0x04A8; // struct APawn* (Self)
            public const uint CameraManager = 0x04D0; // struct APlayerCameraManager* PlayerCameraManager;
        }

        public readonly struct Actor
        {
            // struct AActor : UObject
            public const uint RootComponent = 0x0328; // struct USceneComponent* RootComponent;
        }

        public readonly struct SceneComponent
        {
            public const uint ComponentToWorld = 0x0310; // relative_location (unsure, should be +-20 of current value)
            public const uint Translation = 0x10; // Position !!!
        }

        public readonly struct Character
        {
            // struct ACharacter : APawn
            public const uint Mesh = 0x0570; // struct USkeletalMeshComponent* Mesh;

            public static readonly uint[] HealthXorKeys = new uint[]
            {
                  0xCEC7A59D,
                  0x9B63B26E,
                  0xCA1F0ABD,
                  0x6E384887,
                  0x911D0A,
                  0x23DDAF4C,
                  0x94587C8,
                  0xBD39B421,
                  0xBAF7A58,
                  0xA8EF6E87,
                  0xE2757BB4,
                  0x9F8ADB1C,
                  0xBD00ABD5,
                  0x6E938707,
                  0x87099E38,
                  0xE0D52AB4,

            };

            public const uint HealthIf1 = 0x361; // HealthFlag
            public const uint HealthIf = 0x948; // Health1
            public const uint HealthOffset = 0xA10; // Health2
            public const uint Healthcmp = 0x984; // Health3
            public const uint HealthCheck = 0x970; // Health4
            public const uint HealthBool = 0x0985; // Health5
            public const uint Healthxor = 0x0980; // Health6
           
            
           

            // struct ATslCharacterBase : ACharacter
            public const uint GroggyHealth = 0x11B0; // float GroggyHealth;

            public const uint Name = 0x12C0;

            // struct ATslCharacter : AMutableCharacter
            public const uint Team = 0x1508; // right after "struct ATeam* Team;"
            public const uint SpectatedCount = 0x1DE4; // audience (obfuscated int32)
        }

        public readonly struct Mesh
        {
            // struct UPrimitiveComponent : USceneComponent
            // Right after BoundsScale
            public const uint LastRenderTimeOnScreen = 0x074C; // 3rd float !!!
            public const uint LastSubmitTime = LastRenderTimeOnScreen - 0x8; // 1st float !!!

            // struct UStaticMeshComponent : UMeshComponent
            public const uint StaticMesh = 0x0AC8; // struct UStaticMesh* StaticMesh; (BoneArray)
        }

        public readonly struct CameraManager
        {
            public const uint InfoBase = 0x1610; // Same as Location - Check struct from dump to ensure it's not changed !!!
        }
    }
}
